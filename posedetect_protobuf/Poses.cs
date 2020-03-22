// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: poses.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Polaris.Poses {

  /// <summary>Holder for reflection information generated from poses.proto</summary>
  public static partial class PosesReflection {

    #region Descriptor
    /// <summary>File descriptor for poses.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PosesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgtwb3Nlcy5wcm90bxIFcG9zZXMiQQoSS2V5cG9pbnRFc3RpbWF0aW9uEgkK",
            "AXgYZSABKAISCQoBeRhmIAEoAhIJCgF6GGcgASgCEgoKAXAYyQEgASgCIlIK",
            "GEtleXBvaW50RXN0aW1hdGlvbkZyYW1lcxIKCgJpZBhlIAEoCRIqCgZmcmFt",
            "ZXMYyQEgAygLMhkucG9zZXMuS2V5cG9pbnRFc3RpbWF0aW9uIksKFFBvc2VF",
            "c3RpbWF0aW9uRnJhbWVzEjMKCWtleXBvaW50cxjJASADKAsyHy5wb3Nlcy5L",
            "ZXlwb2ludEVzdGltYXRpb25GcmFtZXMiTAoUUG9zZUVzdGltYXRpb25SZXN1",
            "bHQSNAoPcG9zZUVzdGltYXRpb25zGGUgASgLMhsucG9zZXMuUG9zZUVzdGlt",
            "YXRpb25GcmFtZXNCEKoCDVBvbGFyaXMuUG9zZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Polaris.Poses.KeypointEstimation), global::Polaris.Poses.KeypointEstimation.Parser, new[]{ "X", "Y", "Z", "P" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Polaris.Poses.KeypointEstimationFrames), global::Polaris.Poses.KeypointEstimationFrames.Parser, new[]{ "Id", "Frames" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Polaris.Poses.PoseEstimationFrames), global::Polaris.Poses.PoseEstimationFrames.Parser, new[]{ "Keypoints" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Polaris.Poses.PoseEstimationResult), global::Polaris.Poses.PoseEstimationResult.Parser, new[]{ "PoseEstimations" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class KeypointEstimation : pb::IMessage<KeypointEstimation> {
    private static readonly pb::MessageParser<KeypointEstimation> _parser = new pb::MessageParser<KeypointEstimation>(() => new KeypointEstimation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeypointEstimation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Polaris.Poses.PosesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeypointEstimation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeypointEstimation(KeypointEstimation other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      p_ = other.p_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeypointEstimation Clone() {
      return new KeypointEstimation(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 101;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 102;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 103;
    private float z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "p" field.</summary>
    public const int PFieldNumber = 201;
    private float p_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float P {
      get { return p_; }
      set {
        p_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeypointEstimation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeypointEstimation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(P, other.P)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
      if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
      if (Z != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
      if (P != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(P);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0F) {
        output.WriteRawTag(173, 6);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(181, 6);
        output.WriteFloat(Y);
      }
      if (Z != 0F) {
        output.WriteRawTag(189, 6);
        output.WriteFloat(Z);
      }
      if (P != 0F) {
        output.WriteRawTag(205, 12);
        output.WriteFloat(P);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0F) {
        size += 2 + 4;
      }
      if (Y != 0F) {
        size += 2 + 4;
      }
      if (Z != 0F) {
        size += 2 + 4;
      }
      if (P != 0F) {
        size += 2 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeypointEstimation other) {
      if (other == null) {
        return;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.Z != 0F) {
        Z = other.Z;
      }
      if (other.P != 0F) {
        P = other.P;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 813: {
            X = input.ReadFloat();
            break;
          }
          case 821: {
            Y = input.ReadFloat();
            break;
          }
          case 829: {
            Z = input.ReadFloat();
            break;
          }
          case 1613: {
            P = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class KeypointEstimationFrames : pb::IMessage<KeypointEstimationFrames> {
    private static readonly pb::MessageParser<KeypointEstimationFrames> _parser = new pb::MessageParser<KeypointEstimationFrames>(() => new KeypointEstimationFrames());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeypointEstimationFrames> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Polaris.Poses.PosesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeypointEstimationFrames() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeypointEstimationFrames(KeypointEstimationFrames other) : this() {
      id_ = other.id_;
      frames_ = other.frames_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeypointEstimationFrames Clone() {
      return new KeypointEstimationFrames(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 101;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "frames" field.</summary>
    public const int FramesFieldNumber = 201;
    private static readonly pb::FieldCodec<global::Polaris.Poses.KeypointEstimation> _repeated_frames_codec
        = pb::FieldCodec.ForMessage(1610, global::Polaris.Poses.KeypointEstimation.Parser);
    private readonly pbc::RepeatedField<global::Polaris.Poses.KeypointEstimation> frames_ = new pbc::RepeatedField<global::Polaris.Poses.KeypointEstimation>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Polaris.Poses.KeypointEstimation> Frames {
      get { return frames_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeypointEstimationFrames);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeypointEstimationFrames other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if(!frames_.Equals(other.frames_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      hash ^= frames_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(170, 6);
        output.WriteString(Id);
      }
      frames_.WriteTo(output, _repeated_frames_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      size += frames_.CalculateSize(_repeated_frames_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeypointEstimationFrames other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      frames_.Add(other.frames_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 810: {
            Id = input.ReadString();
            break;
          }
          case 1610: {
            frames_.AddEntriesFrom(input, _repeated_frames_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PoseEstimationFrames : pb::IMessage<PoseEstimationFrames> {
    private static readonly pb::MessageParser<PoseEstimationFrames> _parser = new pb::MessageParser<PoseEstimationFrames>(() => new PoseEstimationFrames());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PoseEstimationFrames> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Polaris.Poses.PosesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoseEstimationFrames() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoseEstimationFrames(PoseEstimationFrames other) : this() {
      keypoints_ = other.keypoints_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoseEstimationFrames Clone() {
      return new PoseEstimationFrames(this);
    }

    /// <summary>Field number for the "keypoints" field.</summary>
    public const int KeypointsFieldNumber = 201;
    private static readonly pb::FieldCodec<global::Polaris.Poses.KeypointEstimationFrames> _repeated_keypoints_codec
        = pb::FieldCodec.ForMessage(1610, global::Polaris.Poses.KeypointEstimationFrames.Parser);
    private readonly pbc::RepeatedField<global::Polaris.Poses.KeypointEstimationFrames> keypoints_ = new pbc::RepeatedField<global::Polaris.Poses.KeypointEstimationFrames>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Polaris.Poses.KeypointEstimationFrames> Keypoints {
      get { return keypoints_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PoseEstimationFrames);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PoseEstimationFrames other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!keypoints_.Equals(other.keypoints_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= keypoints_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      keypoints_.WriteTo(output, _repeated_keypoints_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += keypoints_.CalculateSize(_repeated_keypoints_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PoseEstimationFrames other) {
      if (other == null) {
        return;
      }
      keypoints_.Add(other.keypoints_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 1610: {
            keypoints_.AddEntriesFrom(input, _repeated_keypoints_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PoseEstimationResult : pb::IMessage<PoseEstimationResult> {
    private static readonly pb::MessageParser<PoseEstimationResult> _parser = new pb::MessageParser<PoseEstimationResult>(() => new PoseEstimationResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PoseEstimationResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Polaris.Poses.PosesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoseEstimationResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoseEstimationResult(PoseEstimationResult other) : this() {
      poseEstimations_ = other.poseEstimations_ != null ? other.poseEstimations_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoseEstimationResult Clone() {
      return new PoseEstimationResult(this);
    }

    /// <summary>Field number for the "poseEstimations" field.</summary>
    public const int PoseEstimationsFieldNumber = 101;
    private global::Polaris.Poses.PoseEstimationFrames poseEstimations_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Polaris.Poses.PoseEstimationFrames PoseEstimations {
      get { return poseEstimations_; }
      set {
        poseEstimations_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PoseEstimationResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PoseEstimationResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PoseEstimations, other.PoseEstimations)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (poseEstimations_ != null) hash ^= PoseEstimations.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (poseEstimations_ != null) {
        output.WriteRawTag(170, 6);
        output.WriteMessage(PoseEstimations);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (poseEstimations_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(PoseEstimations);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PoseEstimationResult other) {
      if (other == null) {
        return;
      }
      if (other.poseEstimations_ != null) {
        if (poseEstimations_ == null) {
          PoseEstimations = new global::Polaris.Poses.PoseEstimationFrames();
        }
        PoseEstimations.MergeFrom(other.PoseEstimations);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 810: {
            if (poseEstimations_ == null) {
              PoseEstimations = new global::Polaris.Poses.PoseEstimationFrames();
            }
            input.ReadMessage(PoseEstimations);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
