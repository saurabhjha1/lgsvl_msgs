// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/lgsvl/proto/detection2d.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Common {

  /// <summary>Holder for reflection information generated from modules/lgsvl/proto/detection2d.proto</summary>
  public static partial class Detection2DReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/lgsvl/proto/detection2d.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Detection2DReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVtb2R1bGVzL2xnc3ZsL3Byb3RvL2RldGVjdGlvbjJkLnByb3RvEg1hcG9s",
            "bG8uY29tbW9uGiFtb2R1bGVzL2NvbW1vbi9wcm90by9oZWFkZXIucHJvdG8i",
            "RAoNQm91bmRpbmdCb3gyRBIJCgF4GAEgASgCEgkKAXkYAiABKAISDQoFd2lk",
            "dGgYAyABKAISDgoGaGVpZ2h0GAQgASgCIioKB1ZlY3RvcjMSCQoBeBgBIAEo",
            "ARIJCgF5GAIgASgBEgkKAXoYAyABKAEiWAoFVHdpc3QSJgoGbGluZWFyGAEg",
            "ASgLMhYuYXBvbGxvLmNvbW1vbi5WZWN0b3IzEicKB2FuZ3VsYXIYAiABKAsy",
            "Fi5hcG9sbG8uY29tbW9uLlZlY3RvcjMisgEKC0RldGVjdGlvbjJEEiUKBmhl",
            "YWRlchgBIAEoCzIVLmFwb2xsby5jb21tb24uSGVhZGVyEgoKAmlkGAIgASgN",
            "Eg0KBWxhYmVsGAMgASgJEg0KBXNjb3JlGAQgASgBEioKBGJib3gYBSABKAsy",
            "HC5hcG9sbG8uY29tbW9uLkJvdW5kaW5nQm94MkQSJgoIdmVsb2NpdHkYBiAB",
            "KAsyFC5hcG9sbG8uY29tbW9uLlR3aXN0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Common.HeaderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Common.BoundingBox2D), global::Apollo.Common.BoundingBox2D.Parser, new[]{ "X", "Y", "Width", "Height" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Common.Vector3), global::Apollo.Common.Vector3.Parser, new[]{ "X", "Y", "Z" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Common.Twist), global::Apollo.Common.Twist.Parser, new[]{ "Linear", "Angular" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Common.Detection2D), global::Apollo.Common.Detection2D.Parser, new[]{ "Header", "Id", "Label", "Score", "Bbox", "Velocity" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BoundingBox2D : pb::IMessage<BoundingBox2D> {
    private static readonly pb::MessageParser<BoundingBox2D> _parser = new pb::MessageParser<BoundingBox2D>(() => new BoundingBox2D());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BoundingBox2D> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Common.Detection2DReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundingBox2D() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundingBox2D(BoundingBox2D other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      width_ = other.width_;
      height_ = other.height_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundingBox2D Clone() {
      return new BoundingBox2D(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 3;
    private float width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 4;
    private float height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BoundingBox2D);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BoundingBox2D other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0F) hash ^= X.GetHashCode();
      if (Y != 0F) hash ^= Y.GetHashCode();
      if (Width != 0F) hash ^= Width.GetHashCode();
      if (Height != 0F) hash ^= Height.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Y);
      }
      if (Width != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Width);
      }
      if (Height != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Height);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (Width != 0F) {
        size += 1 + 4;
      }
      if (Height != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BoundingBox2D other) {
      if (other == null) {
        return;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.Width != 0F) {
        Width = other.Width;
      }
      if (other.Height != 0F) {
        Height = other.Height;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            X = input.ReadFloat();
            break;
          }
          case 21: {
            Y = input.ReadFloat();
            break;
          }
          case 29: {
            Width = input.ReadFloat();
            break;
          }
          case 37: {
            Height = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Vector3 : pb::IMessage<Vector3> {
    private static readonly pb::MessageParser<Vector3> _parser = new pb::MessageParser<Vector3>(() => new Vector3());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Vector3> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Common.Detection2DReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3(Vector3 other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3 Clone() {
      return new Vector3(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private double x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private double y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private double z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Vector3);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Vector3 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0D) hash ^= X.GetHashCode();
      if (Y != 0D) hash ^= Y.GetHashCode();
      if (Z != 0D) hash ^= Z.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(X);
      }
      if (Y != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Y);
      }
      if (Z != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Z);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0D) {
        size += 1 + 8;
      }
      if (Y != 0D) {
        size += 1 + 8;
      }
      if (Z != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Vector3 other) {
      if (other == null) {
        return;
      }
      if (other.X != 0D) {
        X = other.X;
      }
      if (other.Y != 0D) {
        Y = other.Y;
      }
      if (other.Z != 0D) {
        Z = other.Z;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 9: {
            X = input.ReadDouble();
            break;
          }
          case 17: {
            Y = input.ReadDouble();
            break;
          }
          case 25: {
            Z = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Twist : pb::IMessage<Twist> {
    private static readonly pb::MessageParser<Twist> _parser = new pb::MessageParser<Twist>(() => new Twist());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Twist> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Common.Detection2DReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Twist() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Twist(Twist other) : this() {
      Linear = other.linear_ != null ? other.Linear.Clone() : null;
      Angular = other.angular_ != null ? other.Angular.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Twist Clone() {
      return new Twist(this);
    }

    /// <summary>Field number for the "linear" field.</summary>
    public const int LinearFieldNumber = 1;
    private global::Apollo.Common.Vector3 linear_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Vector3 Linear {
      get { return linear_; }
      set {
        linear_ = value;
      }
    }

    /// <summary>Field number for the "angular" field.</summary>
    public const int AngularFieldNumber = 2;
    private global::Apollo.Common.Vector3 angular_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Vector3 Angular {
      get { return angular_; }
      set {
        angular_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Twist);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Twist other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Linear, other.Linear)) return false;
      if (!object.Equals(Angular, other.Angular)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (linear_ != null) hash ^= Linear.GetHashCode();
      if (angular_ != null) hash ^= Angular.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (linear_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Linear);
      }
      if (angular_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Angular);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (linear_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Linear);
      }
      if (angular_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Angular);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Twist other) {
      if (other == null) {
        return;
      }
      if (other.linear_ != null) {
        if (linear_ == null) {
          linear_ = new global::Apollo.Common.Vector3();
        }
        Linear.MergeFrom(other.Linear);
      }
      if (other.angular_ != null) {
        if (angular_ == null) {
          angular_ = new global::Apollo.Common.Vector3();
        }
        Angular.MergeFrom(other.Angular);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (linear_ == null) {
              linear_ = new global::Apollo.Common.Vector3();
            }
            input.ReadMessage(linear_);
            break;
          }
          case 18: {
            if (angular_ == null) {
              angular_ = new global::Apollo.Common.Vector3();
            }
            input.ReadMessage(angular_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Detection2D : pb::IMessage<Detection2D> {
    private static readonly pb::MessageParser<Detection2D> _parser = new pb::MessageParser<Detection2D>(() => new Detection2D());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Detection2D> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Common.Detection2DReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Detection2D() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Detection2D(Detection2D other) : this() {
      Header = other.header_ != null ? other.Header.Clone() : null;
      id_ = other.id_;
      label_ = other.label_;
      score_ = other.score_;
      Bbox = other.bbox_ != null ? other.Bbox.Clone() : null;
      Velocity = other.velocity_ != null ? other.Velocity.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Detection2D Clone() {
      return new Detection2D(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Apollo.Common.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 3;
    private string label_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 4;
    private double score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "bbox" field.</summary>
    public const int BboxFieldNumber = 5;
    private global::Apollo.Common.BoundingBox2D bbox_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.BoundingBox2D Bbox {
      get { return bbox_; }
      set {
        bbox_ = value;
      }
    }

    /// <summary>Field number for the "velocity" field.</summary>
    public const int VelocityFieldNumber = 6;
    private global::Apollo.Common.Twist velocity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Twist Velocity {
      get { return velocity_; }
      set {
        velocity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Detection2D);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Detection2D other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (Id != other.Id) return false;
      if (Label != other.Label) return false;
      if (Score != other.Score) return false;
      if (!object.Equals(Bbox, other.Bbox)) return false;
      if (!object.Equals(Velocity, other.Velocity)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (Score != 0D) hash ^= Score.GetHashCode();
      if (bbox_ != null) hash ^= Bbox.GetHashCode();
      if (velocity_ != null) hash ^= Velocity.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Label);
      }
      if (Score != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Score);
      }
      if (bbox_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Bbox);
      }
      if (velocity_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Velocity);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (Score != 0D) {
        size += 1 + 8;
      }
      if (bbox_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Bbox);
      }
      if (velocity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Velocity);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Detection2D other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::Apollo.Common.Header();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      if (other.Score != 0D) {
        Score = other.Score;
      }
      if (other.bbox_ != null) {
        if (bbox_ == null) {
          bbox_ = new global::Apollo.Common.BoundingBox2D();
        }
        Bbox.MergeFrom(other.Bbox);
      }
      if (other.velocity_ != null) {
        if (velocity_ == null) {
          velocity_ = new global::Apollo.Common.Twist();
        }
        Velocity.MergeFrom(other.Velocity);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (header_ == null) {
              header_ = new global::Apollo.Common.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 26: {
            Label = input.ReadString();
            break;
          }
          case 33: {
            Score = input.ReadDouble();
            break;
          }
          case 42: {
            if (bbox_ == null) {
              bbox_ = new global::Apollo.Common.BoundingBox2D();
            }
            input.ReadMessage(bbox_);
            break;
          }
          case 50: {
            if (velocity_ == null) {
              velocity_ = new global::Apollo.Common.Twist();
            }
            input.ReadMessage(velocity_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code