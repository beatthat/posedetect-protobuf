from typing import List
import numpy as np
from .poses_pb2 import PoseEstimationResult


def np_to_protobuf(result_np: np.ndarray, keypoints: List[str]) -> PoseEstimationResult:
    result = PoseEstimationResult()
    for kp_ix, kp_id in enumerate(keypoints):
        kp_frames = result.poseEstimations.keypoints.add()
        kp_frames.id = kp_id
        for frame_ix in range(0, result_np.shape[0]):
            kp = kp_frames.frames.add()
            kp.x, kp.y, kp.z = result_np[frame_ix, kp_ix, 0:3]
    return result


def protobuf_to_np(result_pb: PoseEstimationResult, keypoints: List[str]) -> np.ndarray:
    n_frames = len(result_pb.poseEstimations.keypoints[0].frames)
    result = np.zeros((n_frames, len(keypoints), 3))
    for kp_ix, kp_frames in enumerate(result_pb.poseEstimations.keypoints):
        for frame_ix, kp in enumerate(kp_frames.frames):
            result[frame_ix, kp_ix, 0] = kp.x
            result[frame_ix, kp_ix, 1] = kp.y
            result[frame_ix, kp_ix, 2] = kp.z
    return result
