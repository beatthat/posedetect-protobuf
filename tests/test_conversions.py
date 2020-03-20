from typing import List
import os

import numpy as np

from .helpers import resource_root_for_test
from posedetect_protobuf import convert_pose_estimation_result

KEYPOINTS_DEFAULT = [
    "nose",
    "left_eye",
    "right_eye",
    "left_ear",
    "right_ear",
    "left_shoulder",
    "right_shoulder",
    "left_elbow",
    "right_elbow",
    "left_wrist",
    "right_wrist",
    "left_hip",
    "right_hip",
    "left_knee",
    "right_knee",
    "left_ankle",
    "right_ankle",
]

resource_root = resource_root_for_test(__file__)


def test_roundtrip_with_npy_file():
    test_root = os.path.join(resource_root, "test_roundtrip_with_npy")
    _test_roundtrip_with_np(
        np.load(os.path.join(test_root, "pose_estimations_3d.npy")), KEYPOINTS_DEFAULT
    )


def test_roundtrip_with_np():
    keypoints = ["kp1", "kp2"]
    n_frames = 3
    data = [
        111,
        112,
        113,
        121,
        122,
        123,
        211,
        212,
        213,
        221,
        222,
        223,
        311,
        312,
        313,
        321,
        322,
        323,
    ]
    np_data = np.asarray(data)
    np_data = np.reshape(np_data, (n_frames, len(keypoints), 3))
    _test_roundtrip_with_np(np_data, keypoints)


def _test_roundtrip_with_np(expected_np: np.ndarray, keypoints: List[str]):
    as_protobuf = convert_pose_estimation_result.np_to_protobuf(expected_np, keypoints)
    actual_np = convert_pose_estimation_result.protobuf_to_np(as_protobuf, keypoints)
    assert expected_np.shape == actual_np.shape
    np.testing.assert_array_almost_equal(expected_np, actual_np)
