# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: poses.proto

from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database

# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


DESCRIPTOR = _descriptor.FileDescriptor(
    name="poses.proto",
    package="poses",
    syntax="proto3",
    serialized_options=b"\252\002\020Polaris.Protobuf",
    serialized_pb=b'\n\x0bposes.proto\x12\x05poses"A\n\x12KeypointEstimation\x12\t\n\x01x\x18\x65 \x01(\x02\x12\t\n\x01y\x18\x66 \x01(\x02\x12\t\n\x01z\x18g \x01(\x02\x12\n\n\x01p\x18\xc9\x01 \x01(\x02"R\n\x18KeypointEstimationFrames\x12\n\n\x02id\x18\x65 \x01(\t\x12*\n\x06\x66rames\x18\xc9\x01 \x03(\x0b\x32\x19.poses.KeypointEstimation"K\n\x14PoseEstimationFrames\x12\x33\n\tkeypoints\x18\xc9\x01 \x03(\x0b\x32\x1f.poses.KeypointEstimationFrames"L\n\x14PoseEstimationResult\x12\x34\n\x0fposeEstimations\x18\x65 \x01(\x0b\x32\x1b.poses.PoseEstimationFramesB\x13\xaa\x02\x10Polaris.Protobufb\x06proto3',
)


_KEYPOINTESTIMATION = _descriptor.Descriptor(
    name="KeypointEstimation",
    full_name="poses.KeypointEstimation",
    filename=None,
    file=DESCRIPTOR,
    containing_type=None,
    fields=[
        _descriptor.FieldDescriptor(
            name="x",
            full_name="poses.KeypointEstimation.x",
            index=0,
            number=101,
            type=2,
            cpp_type=6,
            label=1,
            has_default_value=False,
            default_value=float(0),
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
        ),
        _descriptor.FieldDescriptor(
            name="y",
            full_name="poses.KeypointEstimation.y",
            index=1,
            number=102,
            type=2,
            cpp_type=6,
            label=1,
            has_default_value=False,
            default_value=float(0),
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
        ),
        _descriptor.FieldDescriptor(
            name="z",
            full_name="poses.KeypointEstimation.z",
            index=2,
            number=103,
            type=2,
            cpp_type=6,
            label=1,
            has_default_value=False,
            default_value=float(0),
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
        ),
        _descriptor.FieldDescriptor(
            name="p",
            full_name="poses.KeypointEstimation.p",
            index=3,
            number=201,
            type=2,
            cpp_type=6,
            label=1,
            has_default_value=False,
            default_value=float(0),
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
        ),
    ],
    extensions=[],
    nested_types=[],
    enum_types=[],
    serialized_options=None,
    is_extendable=False,
    syntax="proto3",
    extension_ranges=[],
    oneofs=[],
    serialized_start=22,
    serialized_end=87,
)


_KEYPOINTESTIMATIONFRAMES = _descriptor.Descriptor(
    name="KeypointEstimationFrames",
    full_name="poses.KeypointEstimationFrames",
    filename=None,
    file=DESCRIPTOR,
    containing_type=None,
    fields=[
        _descriptor.FieldDescriptor(
            name="id",
            full_name="poses.KeypointEstimationFrames.id",
            index=0,
            number=101,
            type=9,
            cpp_type=9,
            label=1,
            has_default_value=False,
            default_value=b"".decode("utf-8"),
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
        ),
        _descriptor.FieldDescriptor(
            name="frames",
            full_name="poses.KeypointEstimationFrames.frames",
            index=1,
            number=201,
            type=11,
            cpp_type=10,
            label=3,
            has_default_value=False,
            default_value=[],
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
        ),
    ],
    extensions=[],
    nested_types=[],
    enum_types=[],
    serialized_options=None,
    is_extendable=False,
    syntax="proto3",
    extension_ranges=[],
    oneofs=[],
    serialized_start=89,
    serialized_end=171,
)


_POSEESTIMATIONFRAMES = _descriptor.Descriptor(
    name="PoseEstimationFrames",
    full_name="poses.PoseEstimationFrames",
    filename=None,
    file=DESCRIPTOR,
    containing_type=None,
    fields=[
        _descriptor.FieldDescriptor(
            name="keypoints",
            full_name="poses.PoseEstimationFrames.keypoints",
            index=0,
            number=201,
            type=11,
            cpp_type=10,
            label=3,
            has_default_value=False,
            default_value=[],
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
        )
    ],
    extensions=[],
    nested_types=[],
    enum_types=[],
    serialized_options=None,
    is_extendable=False,
    syntax="proto3",
    extension_ranges=[],
    oneofs=[],
    serialized_start=173,
    serialized_end=248,
)


_POSEESTIMATIONRESULT = _descriptor.Descriptor(
    name="PoseEstimationResult",
    full_name="poses.PoseEstimationResult",
    filename=None,
    file=DESCRIPTOR,
    containing_type=None,
    fields=[
        _descriptor.FieldDescriptor(
            name="poseEstimations",
            full_name="poses.PoseEstimationResult.poseEstimations",
            index=0,
            number=101,
            type=11,
            cpp_type=10,
            label=1,
            has_default_value=False,
            default_value=None,
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
        )
    ],
    extensions=[],
    nested_types=[],
    enum_types=[],
    serialized_options=None,
    is_extendable=False,
    syntax="proto3",
    extension_ranges=[],
    oneofs=[],
    serialized_start=250,
    serialized_end=326,
)

_KEYPOINTESTIMATIONFRAMES.fields_by_name["frames"].message_type = _KEYPOINTESTIMATION
_POSEESTIMATIONFRAMES.fields_by_name[
    "keypoints"
].message_type = _KEYPOINTESTIMATIONFRAMES
_POSEESTIMATIONRESULT.fields_by_name[
    "poseEstimations"
].message_type = _POSEESTIMATIONFRAMES
DESCRIPTOR.message_types_by_name["KeypointEstimation"] = _KEYPOINTESTIMATION
DESCRIPTOR.message_types_by_name["KeypointEstimationFrames"] = _KEYPOINTESTIMATIONFRAMES
DESCRIPTOR.message_types_by_name["PoseEstimationFrames"] = _POSEESTIMATIONFRAMES
DESCRIPTOR.message_types_by_name["PoseEstimationResult"] = _POSEESTIMATIONRESULT
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

KeypointEstimation = _reflection.GeneratedProtocolMessageType(
    "KeypointEstimation",
    (_message.Message,),
    {
        "DESCRIPTOR": _KEYPOINTESTIMATION,
        "__module__": "poses_pb2"
        # @@protoc_insertion_point(class_scope:poses.KeypointEstimation)
    },
)
_sym_db.RegisterMessage(KeypointEstimation)

KeypointEstimationFrames = _reflection.GeneratedProtocolMessageType(
    "KeypointEstimationFrames",
    (_message.Message,),
    {
        "DESCRIPTOR": _KEYPOINTESTIMATIONFRAMES,
        "__module__": "poses_pb2"
        # @@protoc_insertion_point(class_scope:poses.KeypointEstimationFrames)
    },
)
_sym_db.RegisterMessage(KeypointEstimationFrames)

PoseEstimationFrames = _reflection.GeneratedProtocolMessageType(
    "PoseEstimationFrames",
    (_message.Message,),
    {
        "DESCRIPTOR": _POSEESTIMATIONFRAMES,
        "__module__": "poses_pb2"
        # @@protoc_insertion_point(class_scope:poses.PoseEstimationFrames)
    },
)
_sym_db.RegisterMessage(PoseEstimationFrames)

PoseEstimationResult = _reflection.GeneratedProtocolMessageType(
    "PoseEstimationResult",
    (_message.Message,),
    {
        "DESCRIPTOR": _POSEESTIMATIONRESULT,
        "__module__": "poses_pb2"
        # @@protoc_insertion_point(class_scope:poses.PoseEstimationResult)
    },
)
_sym_db.RegisterMessage(PoseEstimationResult)


DESCRIPTOR._options = None
# @@protoc_insertion_point(module_scope)
