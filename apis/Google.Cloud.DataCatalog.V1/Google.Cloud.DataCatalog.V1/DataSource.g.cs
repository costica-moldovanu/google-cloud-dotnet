// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/data_source.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataCatalog.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/datacatalog/v1/data_source.proto</summary>
  public static partial class DataSourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/datacatalog/v1/data_source.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataSourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvZGF0YWNhdGFsb2cvdjEvZGF0YV9zb3VyY2UucHJv",
            "dG8SG2dvb2dsZS5jbG91ZC5kYXRhY2F0YWxvZy52MRofZ29vZ2xlL2FwaS9m",
            "aWVsZF9iZWhhdmlvci5wcm90byKcAgoKRGF0YVNvdXJjZRJACgdzZXJ2aWNl",
            "GAEgASgOMi8uZ29vZ2xlLmNsb3VkLmRhdGFjYXRhbG9nLnYxLkRhdGFTb3Vy",
            "Y2UuU2VydmljZRIQCghyZXNvdXJjZRgCIAEoCRIZCgxzb3VyY2VfZW50cnkY",
            "AyABKAlCA+BBAxJMChJzdG9yYWdlX3Byb3BlcnRpZXMYBCABKAsyLi5nb29n",
            "bGUuY2xvdWQuZGF0YWNhdGFsb2cudjEuU3RvcmFnZVByb3BlcnRpZXNIACJD",
            "CgdTZXJ2aWNlEhcKE1NFUlZJQ0VfVU5TUEVDSUZJRUQQABIRCg1DTE9VRF9T",
            "VE9SQUdFEAESDAoIQklHUVVFUlkQAkIMCgpwcm9wZXJ0aWVzIjwKEVN0b3Jh",
            "Z2VQcm9wZXJ0aWVzEhQKDGZpbGVfcGF0dGVybhgBIAMoCRIRCglmaWxlX3R5",
            "cGUYAiABKAlC1AEKH2NvbS5nb29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjFC",
            "D0RhdGFTb3VyY2VQcm90b1ABWkFjbG91ZC5nb29nbGUuY29tL2dvL2RhdGFj",
            "YXRhbG9nL2FwaXYxL2RhdGFjYXRhbG9ncGI7ZGF0YWNhdGFsb2dwYqoCG0dv",
            "b2dsZS5DbG91ZC5EYXRhQ2F0YWxvZy5WMcoCG0dvb2dsZVxDbG91ZFxEYXRh",
            "Q2F0YWxvZ1xWMeoCHkdvb2dsZTo6Q2xvdWQ6OkRhdGFDYXRhbG9nOjpWMWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.DataSource), global::Google.Cloud.DataCatalog.V1.DataSource.Parser, new[]{ "Service", "Resource", "SourceEntry", "StorageProperties" }, new[]{ "Properties" }, new[]{ typeof(global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.StorageProperties), global::Google.Cloud.DataCatalog.V1.StorageProperties.Parser, new[]{ "FilePattern", "FileType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Physical location of an entry.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DataSource : pb::IMessage<DataSource>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DataSource> _parser = new pb::MessageParser<DataSource>(() => new DataSource());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DataSource> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.DataSourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataSource() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataSource(DataSource other) : this() {
      service_ = other.service_;
      resource_ = other.resource_;
      sourceEntry_ = other.sourceEntry_;
      switch (other.PropertiesCase) {
        case PropertiesOneofCase.StorageProperties:
          StorageProperties = other.StorageProperties.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataSource Clone() {
      return new DataSource(this);
    }

    /// <summary>Field number for the "service" field.</summary>
    public const int ServiceFieldNumber = 1;
    private global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service service_ = global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service.Unspecified;
    /// <summary>
    /// Service that physically stores the data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service Service {
      get { return service_; }
      set {
        service_ = value;
      }
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 2;
    private string resource_ = "";
    /// <summary>
    /// Full name of a resource as defined by the service. For example:
    ///
    /// `//bigquery.googleapis.com/projects/{PROJECT_ID}/locations/{LOCATION}/datasets/{DATASET_ID}/tables/{TABLE_ID}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Resource {
      get { return resource_; }
      set {
        resource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source_entry" field.</summary>
    public const int SourceEntryFieldNumber = 3;
    private string sourceEntry_ = "";
    /// <summary>
    /// Output only. Data Catalog entry name, if applicable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SourceEntry {
      get { return sourceEntry_; }
      set {
        sourceEntry_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "storage_properties" field.</summary>
    public const int StoragePropertiesFieldNumber = 4;
    /// <summary>
    /// Detailed properties of the underlying storage.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DataCatalog.V1.StorageProperties StorageProperties {
      get { return propertiesCase_ == PropertiesOneofCase.StorageProperties ? (global::Google.Cloud.DataCatalog.V1.StorageProperties) properties_ : null; }
      set {
        properties_ = value;
        propertiesCase_ = value == null ? PropertiesOneofCase.None : PropertiesOneofCase.StorageProperties;
      }
    }

    private object properties_;
    /// <summary>Enum of possible cases for the "properties" oneof.</summary>
    public enum PropertiesOneofCase {
      None = 0,
      StorageProperties = 4,
    }
    private PropertiesOneofCase propertiesCase_ = PropertiesOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropertiesOneofCase PropertiesCase {
      get { return propertiesCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearProperties() {
      propertiesCase_ = PropertiesOneofCase.None;
      properties_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DataSource);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DataSource other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Service != other.Service) return false;
      if (Resource != other.Resource) return false;
      if (SourceEntry != other.SourceEntry) return false;
      if (!object.Equals(StorageProperties, other.StorageProperties)) return false;
      if (PropertiesCase != other.PropertiesCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Service != global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service.Unspecified) hash ^= Service.GetHashCode();
      if (Resource.Length != 0) hash ^= Resource.GetHashCode();
      if (SourceEntry.Length != 0) hash ^= SourceEntry.GetHashCode();
      if (propertiesCase_ == PropertiesOneofCase.StorageProperties) hash ^= StorageProperties.GetHashCode();
      hash ^= (int) propertiesCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Service != global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Service);
      }
      if (Resource.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Resource);
      }
      if (SourceEntry.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SourceEntry);
      }
      if (propertiesCase_ == PropertiesOneofCase.StorageProperties) {
        output.WriteRawTag(34);
        output.WriteMessage(StorageProperties);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Service != global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Service);
      }
      if (Resource.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Resource);
      }
      if (SourceEntry.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SourceEntry);
      }
      if (propertiesCase_ == PropertiesOneofCase.StorageProperties) {
        output.WriteRawTag(34);
        output.WriteMessage(StorageProperties);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Service != global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Service);
      }
      if (Resource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Resource);
      }
      if (SourceEntry.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceEntry);
      }
      if (propertiesCase_ == PropertiesOneofCase.StorageProperties) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StorageProperties);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DataSource other) {
      if (other == null) {
        return;
      }
      if (other.Service != global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service.Unspecified) {
        Service = other.Service;
      }
      if (other.Resource.Length != 0) {
        Resource = other.Resource;
      }
      if (other.SourceEntry.Length != 0) {
        SourceEntry = other.SourceEntry;
      }
      switch (other.PropertiesCase) {
        case PropertiesOneofCase.StorageProperties:
          if (StorageProperties == null) {
            StorageProperties = new global::Google.Cloud.DataCatalog.V1.StorageProperties();
          }
          StorageProperties.MergeFrom(other.StorageProperties);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Service = (global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service) input.ReadEnum();
            break;
          }
          case 18: {
            Resource = input.ReadString();
            break;
          }
          case 26: {
            SourceEntry = input.ReadString();
            break;
          }
          case 34: {
            global::Google.Cloud.DataCatalog.V1.StorageProperties subBuilder = new global::Google.Cloud.DataCatalog.V1.StorageProperties();
            if (propertiesCase_ == PropertiesOneofCase.StorageProperties) {
              subBuilder.MergeFrom(StorageProperties);
            }
            input.ReadMessage(subBuilder);
            StorageProperties = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Service = (global::Google.Cloud.DataCatalog.V1.DataSource.Types.Service) input.ReadEnum();
            break;
          }
          case 18: {
            Resource = input.ReadString();
            break;
          }
          case 26: {
            SourceEntry = input.ReadString();
            break;
          }
          case 34: {
            global::Google.Cloud.DataCatalog.V1.StorageProperties subBuilder = new global::Google.Cloud.DataCatalog.V1.StorageProperties();
            if (propertiesCase_ == PropertiesOneofCase.StorageProperties) {
              subBuilder.MergeFrom(StorageProperties);
            }
            input.ReadMessage(subBuilder);
            StorageProperties = subBuilder;
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DataSource message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Name of a service that stores the data.
      /// </summary>
      public enum Service {
        /// <summary>
        /// Default unknown service.
        /// </summary>
        [pbr::OriginalName("SERVICE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Google Cloud Storage service.
        /// </summary>
        [pbr::OriginalName("CLOUD_STORAGE")] CloudStorage = 1,
        /// <summary>
        /// BigQuery service.
        /// </summary>
        [pbr::OriginalName("BIGQUERY")] Bigquery = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// Details the properties of the underlying storage.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StorageProperties : pb::IMessage<StorageProperties>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StorageProperties> _parser = new pb::MessageParser<StorageProperties>(() => new StorageProperties());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StorageProperties> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.DataSourceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StorageProperties() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StorageProperties(StorageProperties other) : this() {
      filePattern_ = other.filePattern_.Clone();
      fileType_ = other.fileType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StorageProperties Clone() {
      return new StorageProperties(this);
    }

    /// <summary>Field number for the "file_pattern" field.</summary>
    public const int FilePatternFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_filePattern_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> filePattern_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Patterns to identify a set of files for this fileset.
    ///
    /// Examples of a valid `file_pattern`:
    ///
    ///  * `gs://bucket_name/dir/*`: matches all files in the `bucket_name/dir`
    ///                              directory
    ///  * `gs://bucket_name/dir/**`: matches all files in the `bucket_name/dir`
    ///                               and all subdirectories recursively
    ///  * `gs://bucket_name/file*`: matches files prefixed by `file` in
    ///                              `bucket_name`
    ///  * `gs://bucket_name/??.txt`: matches files with two characters followed by
    ///                               `.txt` in `bucket_name`
    ///  * `gs://bucket_name/[aeiou].txt`: matches files that contain a single
    ///                                    vowel character followed by `.txt` in
    ///                                    `bucket_name`
    ///  * `gs://bucket_name/[a-m].txt`: matches files that contain `a`, `b`, ...
    ///                                  or `m` followed by `.txt` in `bucket_name`
    ///  * `gs://bucket_name/a/*/b`: matches all files in `bucket_name` that match
    ///                              the `a/*/b` pattern, such as `a/c/b`, `a/d/b`
    ///  * `gs://another_bucket/a.txt`: matches `gs://another_bucket/a.txt`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> FilePattern {
      get { return filePattern_; }
    }

    /// <summary>Field number for the "file_type" field.</summary>
    public const int FileTypeFieldNumber = 2;
    private string fileType_ = "";
    /// <summary>
    /// File type in MIME format, for example, `text/plain`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FileType {
      get { return fileType_; }
      set {
        fileType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StorageProperties);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StorageProperties other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!filePattern_.Equals(other.filePattern_)) return false;
      if (FileType != other.FileType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= filePattern_.GetHashCode();
      if (FileType.Length != 0) hash ^= FileType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      filePattern_.WriteTo(output, _repeated_filePattern_codec);
      if (FileType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FileType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      filePattern_.WriteTo(ref output, _repeated_filePattern_codec);
      if (FileType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FileType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += filePattern_.CalculateSize(_repeated_filePattern_codec);
      if (FileType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StorageProperties other) {
      if (other == null) {
        return;
      }
      filePattern_.Add(other.filePattern_);
      if (other.FileType.Length != 0) {
        FileType = other.FileType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            filePattern_.AddEntriesFrom(input, _repeated_filePattern_codec);
            break;
          }
          case 18: {
            FileType = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            filePattern_.AddEntriesFrom(ref input, _repeated_filePattern_codec);
            break;
          }
          case 18: {
            FileType = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
