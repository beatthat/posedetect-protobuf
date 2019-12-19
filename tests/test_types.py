from tempfile import mkdtemp
from typing import Tuple
import os

from posedetect_protobuf.poses_pb2 import (
    KeypointEstimation,
    KeypointEstimationFrames,
    PoseEstimationFrames,
    PoseEstimationResult,
)


def test_keypoint_estimation_write_and_read():
    testdir = mkdtemp()
    kp = KeypointEstimation()
    kp.x = 1
    kp.y = 2
    kp_file = os.path.join(testdir, "kp.proto")
    with open(kp_file, "wb") as w:
        w.write(kp.SerializeToString())
    actual_kp = KeypointEstimation()
    with open(kp_file, "rb") as r:
        actual_kp.ParseFromString(r.read())
    assert actual_kp.x == 1
    assert actual_kp.y == 2


def _gen_kp_frames(
    id: str, n_kps: int, kp_frames: KeypointEstimationFrames = None
) -> KeypointEstimationFrames:
    kp_frames = kp_frames or KeypointEstimationFrames()
    kp_frames.id = id
    for i in range(0, n_kps):
        kp = kp_frames.frames.add()
        kp.x = i * 4
        kp.y = i * 4 + 1
        kp.z = i * 4 + 2
        kp.p = i * 4 + 3
    return kp_frames


def _gen_pe_list(
    kp_ids_and_nkps: Tuple[str, int], pe_list: PoseEstimationFrames = None
) -> PoseEstimationFrames:
    pe_list = pe_list or PoseEstimationFrames()
    for id, n in kp_ids_and_nkps:
        kp_frames = pe_list.keypoints.add()
        _gen_kp_frames(id, n, kp_frames=kp_frames)
    return pe_list


def test_keypoint_estimation_list_write_and_read():
    testdir = mkdtemp()
    expected_kp_frames = _gen_kp_frames("left_arm", 3)
    kp_file = os.path.join(testdir, "test.proto")
    with open(kp_file, "wb") as w:
        w.write(expected_kp_frames.SerializeToString())
    actual_kp_frames = KeypointEstimationFrames()
    with open(kp_file, "rb") as r:
        actual_kp_frames.ParseFromString(r.read())
    assert actual_kp_frames == expected_kp_frames
    assert actual_kp_frames.id == "left_arm"


def test_pose_estimation_list_write_and_read():
    testdir = mkdtemp()
    expected = _gen_pe_list([("leg_right", 2), ("leg_left", 2), ("back", 2)])
    f = os.path.join(testdir, "test.proto")
    with open(f, "wb") as w:
        w.write(expected.SerializeToString())
    actual = PoseEstimationFrames()
    with open(f, "rb") as r:
        actual.ParseFromString(r.read())
    assert actual == expected


def test_pose_estimation_result_write_and_read():
    testdir = mkdtemp()
    expected = PoseEstimationResult()
    expected.poseEstimations.CopyFrom(
        _gen_pe_list([("left_arm", 3), ("right_arm", 3), ("back", 2)])
    )
    f = os.path.join(testdir, "test.proto")
    with open(f, "wb") as w:
        w.write(expected.SerializeToString())
    actual = PoseEstimationResult()
    with open(f, "rb") as r:
        actual.ParseFromString(r.read())
    assert actual == expected
