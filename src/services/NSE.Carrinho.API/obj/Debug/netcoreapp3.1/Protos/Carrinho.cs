// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/carrinho.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NSE.Carrinho.API.Services.gRPC {

  /// <summary>Holder for reflection information generated from Protos/carrinho.proto</summary>
  public static partial class CarrinhoReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/carrinho.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CarrinhoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvY2FycmluaG8ucHJvdG8SC0NhcnJpbmhvQVBJIhYKFE9idGVy",
            "Q2FycmluaG9SZXF1ZXN0ItkBChdDYXJyaW5ob0NsaWVudGVSZXNwb25zZRIK",
            "CgJpZBgBIAEoCRIRCgljbGllbnRlaWQYAiABKAkSEgoKdmFsb3J0b3RhbBgD",
            "IAEoARIwCgVpdGVucxgEIAMoCzIhLkNhcnJpbmhvQVBJLkNhcnJpbmhvSXRl",
            "bVJlc3BvbnNlEhgKEHZvdWNoZXJ1dGlsaXphZG8YBSABKAgSEAoIZGVzY29u",
            "dG8YBiABKAESLQoHdm91Y2hlchgHIAEoCzIcLkNhcnJpbmhvQVBJLlZvdWNo",
            "ZXJSZXNwb25zZSJ2ChRDYXJyaW5ob0l0ZW1SZXNwb25zZRIKCgJpZBgBIAEo",
            "CRIRCglwcm9kdXRvaWQYAiABKAkSDAoEbm9tZRgDIAEoCRISCgpxdWFudGlk",
            "YWRlGAQgASgFEg0KBXZhbG9yGAUgASgBEg4KBmltYWdlbRgGIAEoCSJiCg9W",
            "b3VjaGVyUmVzcG9uc2USEgoKcGVyY2VudHVhbBgBIAEoARIVCg12YWxvcmRl",
            "c2NvbnRvGAIgASgBEg4KBmNvZGlnbxgDIAEoCRIUCgx0aXBvZGVzY29udG8Y",
            "BCABKAUybQoPQ2FycmluaG9Db21wcmFzEloKDU9idGVyQ2FycmluaG8SIS5D",
            "YXJyaW5ob0FQSS5PYnRlckNhcnJpbmhvUmVxdWVzdBokLkNhcnJpbmhvQVBJ",
            "LkNhcnJpbmhvQ2xpZW50ZVJlc3BvbnNlIgBCIaoCHk5TRS5DYXJyaW5oby5B",
            "UEkuU2VydmljZXMuZ1JQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest), global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse), global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse.Parser, new[]{ "Id", "Clienteid", "Valortotal", "Itens", "Voucherutilizado", "Desconto", "Voucher" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NSE.Carrinho.API.Services.gRPC.CarrinhoItemResponse), global::NSE.Carrinho.API.Services.gRPC.CarrinhoItemResponse.Parser, new[]{ "Id", "Produtoid", "Nome", "Quantidade", "Valor", "Imagem" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NSE.Carrinho.API.Services.gRPC.VoucherResponse), global::NSE.Carrinho.API.Services.gRPC.VoucherResponse.Parser, new[]{ "Percentual", "Valordesconto", "Codigo", "Tipodesconto" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ObterCarrinhoRequest : pb::IMessage<ObterCarrinhoRequest> {
    private static readonly pb::MessageParser<ObterCarrinhoRequest> _parser = new pb::MessageParser<ObterCarrinhoRequest>(() => new ObterCarrinhoRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ObterCarrinhoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NSE.Carrinho.API.Services.gRPC.CarrinhoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObterCarrinhoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObterCarrinhoRequest(ObterCarrinhoRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObterCarrinhoRequest Clone() {
      return new ObterCarrinhoRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ObterCarrinhoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ObterCarrinhoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ObterCarrinhoRequest other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class CarrinhoClienteResponse : pb::IMessage<CarrinhoClienteResponse> {
    private static readonly pb::MessageParser<CarrinhoClienteResponse> _parser = new pb::MessageParser<CarrinhoClienteResponse>(() => new CarrinhoClienteResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CarrinhoClienteResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NSE.Carrinho.API.Services.gRPC.CarrinhoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarrinhoClienteResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarrinhoClienteResponse(CarrinhoClienteResponse other) : this() {
      id_ = other.id_;
      clienteid_ = other.clienteid_;
      valortotal_ = other.valortotal_;
      itens_ = other.itens_.Clone();
      voucherutilizado_ = other.voucherutilizado_;
      desconto_ = other.desconto_;
      voucher_ = other.voucher_ != null ? other.voucher_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarrinhoClienteResponse Clone() {
      return new CarrinhoClienteResponse(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "clienteid" field.</summary>
    public const int ClienteidFieldNumber = 2;
    private string clienteid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Clienteid {
      get { return clienteid_; }
      set {
        clienteid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "valortotal" field.</summary>
    public const int ValortotalFieldNumber = 3;
    private double valortotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Valortotal {
      get { return valortotal_; }
      set {
        valortotal_ = value;
      }
    }

    /// <summary>Field number for the "itens" field.</summary>
    public const int ItensFieldNumber = 4;
    private static readonly pb::FieldCodec<global::NSE.Carrinho.API.Services.gRPC.CarrinhoItemResponse> _repeated_itens_codec
        = pb::FieldCodec.ForMessage(34, global::NSE.Carrinho.API.Services.gRPC.CarrinhoItemResponse.Parser);
    private readonly pbc::RepeatedField<global::NSE.Carrinho.API.Services.gRPC.CarrinhoItemResponse> itens_ = new pbc::RepeatedField<global::NSE.Carrinho.API.Services.gRPC.CarrinhoItemResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::NSE.Carrinho.API.Services.gRPC.CarrinhoItemResponse> Itens {
      get { return itens_; }
    }

    /// <summary>Field number for the "voucherutilizado" field.</summary>
    public const int VoucherutilizadoFieldNumber = 5;
    private bool voucherutilizado_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Voucherutilizado {
      get { return voucherutilizado_; }
      set {
        voucherutilizado_ = value;
      }
    }

    /// <summary>Field number for the "desconto" field.</summary>
    public const int DescontoFieldNumber = 6;
    private double desconto_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Desconto {
      get { return desconto_; }
      set {
        desconto_ = value;
      }
    }

    /// <summary>Field number for the "voucher" field.</summary>
    public const int VoucherFieldNumber = 7;
    private global::NSE.Carrinho.API.Services.gRPC.VoucherResponse voucher_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::NSE.Carrinho.API.Services.gRPC.VoucherResponse Voucher {
      get { return voucher_; }
      set {
        voucher_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CarrinhoClienteResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CarrinhoClienteResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Clienteid != other.Clienteid) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Valortotal, other.Valortotal)) return false;
      if(!itens_.Equals(other.itens_)) return false;
      if (Voucherutilizado != other.Voucherutilizado) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Desconto, other.Desconto)) return false;
      if (!object.Equals(Voucher, other.Voucher)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Clienteid.Length != 0) hash ^= Clienteid.GetHashCode();
      if (Valortotal != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Valortotal);
      hash ^= itens_.GetHashCode();
      if (Voucherutilizado != false) hash ^= Voucherutilizado.GetHashCode();
      if (Desconto != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Desconto);
      if (voucher_ != null) hash ^= Voucher.GetHashCode();
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
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Clienteid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Clienteid);
      }
      if (Valortotal != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Valortotal);
      }
      itens_.WriteTo(output, _repeated_itens_codec);
      if (Voucherutilizado != false) {
        output.WriteRawTag(40);
        output.WriteBool(Voucherutilizado);
      }
      if (Desconto != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Desconto);
      }
      if (voucher_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Voucher);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Clienteid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Clienteid);
      }
      if (Valortotal != 0D) {
        size += 1 + 8;
      }
      size += itens_.CalculateSize(_repeated_itens_codec);
      if (Voucherutilizado != false) {
        size += 1 + 1;
      }
      if (Desconto != 0D) {
        size += 1 + 8;
      }
      if (voucher_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Voucher);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CarrinhoClienteResponse other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Clienteid.Length != 0) {
        Clienteid = other.Clienteid;
      }
      if (other.Valortotal != 0D) {
        Valortotal = other.Valortotal;
      }
      itens_.Add(other.itens_);
      if (other.Voucherutilizado != false) {
        Voucherutilizado = other.Voucherutilizado;
      }
      if (other.Desconto != 0D) {
        Desconto = other.Desconto;
      }
      if (other.voucher_ != null) {
        if (voucher_ == null) {
          Voucher = new global::NSE.Carrinho.API.Services.gRPC.VoucherResponse();
        }
        Voucher.MergeFrom(other.Voucher);
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
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Clienteid = input.ReadString();
            break;
          }
          case 25: {
            Valortotal = input.ReadDouble();
            break;
          }
          case 34: {
            itens_.AddEntriesFrom(input, _repeated_itens_codec);
            break;
          }
          case 40: {
            Voucherutilizado = input.ReadBool();
            break;
          }
          case 49: {
            Desconto = input.ReadDouble();
            break;
          }
          case 58: {
            if (voucher_ == null) {
              Voucher = new global::NSE.Carrinho.API.Services.gRPC.VoucherResponse();
            }
            input.ReadMessage(Voucher);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CarrinhoItemResponse : pb::IMessage<CarrinhoItemResponse> {
    private static readonly pb::MessageParser<CarrinhoItemResponse> _parser = new pb::MessageParser<CarrinhoItemResponse>(() => new CarrinhoItemResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CarrinhoItemResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NSE.Carrinho.API.Services.gRPC.CarrinhoReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarrinhoItemResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarrinhoItemResponse(CarrinhoItemResponse other) : this() {
      id_ = other.id_;
      produtoid_ = other.produtoid_;
      nome_ = other.nome_;
      quantidade_ = other.quantidade_;
      valor_ = other.valor_;
      imagem_ = other.imagem_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarrinhoItemResponse Clone() {
      return new CarrinhoItemResponse(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "produtoid" field.</summary>
    public const int ProdutoidFieldNumber = 2;
    private string produtoid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Produtoid {
      get { return produtoid_; }
      set {
        produtoid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nome" field.</summary>
    public const int NomeFieldNumber = 3;
    private string nome_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nome {
      get { return nome_; }
      set {
        nome_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quantidade" field.</summary>
    public const int QuantidadeFieldNumber = 4;
    private int quantidade_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Quantidade {
      get { return quantidade_; }
      set {
        quantidade_ = value;
      }
    }

    /// <summary>Field number for the "valor" field.</summary>
    public const int ValorFieldNumber = 5;
    private double valor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Valor {
      get { return valor_; }
      set {
        valor_ = value;
      }
    }

    /// <summary>Field number for the "imagem" field.</summary>
    public const int ImagemFieldNumber = 6;
    private string imagem_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Imagem {
      get { return imagem_; }
      set {
        imagem_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CarrinhoItemResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CarrinhoItemResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Produtoid != other.Produtoid) return false;
      if (Nome != other.Nome) return false;
      if (Quantidade != other.Quantidade) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Valor, other.Valor)) return false;
      if (Imagem != other.Imagem) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Produtoid.Length != 0) hash ^= Produtoid.GetHashCode();
      if (Nome.Length != 0) hash ^= Nome.GetHashCode();
      if (Quantidade != 0) hash ^= Quantidade.GetHashCode();
      if (Valor != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Valor);
      if (Imagem.Length != 0) hash ^= Imagem.GetHashCode();
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
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Produtoid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Produtoid);
      }
      if (Nome.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nome);
      }
      if (Quantidade != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Quantidade);
      }
      if (Valor != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Valor);
      }
      if (Imagem.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Imagem);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Produtoid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Produtoid);
      }
      if (Nome.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nome);
      }
      if (Quantidade != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantidade);
      }
      if (Valor != 0D) {
        size += 1 + 8;
      }
      if (Imagem.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Imagem);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CarrinhoItemResponse other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Produtoid.Length != 0) {
        Produtoid = other.Produtoid;
      }
      if (other.Nome.Length != 0) {
        Nome = other.Nome;
      }
      if (other.Quantidade != 0) {
        Quantidade = other.Quantidade;
      }
      if (other.Valor != 0D) {
        Valor = other.Valor;
      }
      if (other.Imagem.Length != 0) {
        Imagem = other.Imagem;
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
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Produtoid = input.ReadString();
            break;
          }
          case 26: {
            Nome = input.ReadString();
            break;
          }
          case 32: {
            Quantidade = input.ReadInt32();
            break;
          }
          case 41: {
            Valor = input.ReadDouble();
            break;
          }
          case 50: {
            Imagem = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class VoucherResponse : pb::IMessage<VoucherResponse> {
    private static readonly pb::MessageParser<VoucherResponse> _parser = new pb::MessageParser<VoucherResponse>(() => new VoucherResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VoucherResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NSE.Carrinho.API.Services.gRPC.CarrinhoReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VoucherResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VoucherResponse(VoucherResponse other) : this() {
      percentual_ = other.percentual_;
      valordesconto_ = other.valordesconto_;
      codigo_ = other.codigo_;
      tipodesconto_ = other.tipodesconto_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VoucherResponse Clone() {
      return new VoucherResponse(this);
    }

    /// <summary>Field number for the "percentual" field.</summary>
    public const int PercentualFieldNumber = 1;
    private double percentual_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Percentual {
      get { return percentual_; }
      set {
        percentual_ = value;
      }
    }

    /// <summary>Field number for the "valordesconto" field.</summary>
    public const int ValordescontoFieldNumber = 2;
    private double valordesconto_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Valordesconto {
      get { return valordesconto_; }
      set {
        valordesconto_ = value;
      }
    }

    /// <summary>Field number for the "codigo" field.</summary>
    public const int CodigoFieldNumber = 3;
    private string codigo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Codigo {
      get { return codigo_; }
      set {
        codigo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tipodesconto" field.</summary>
    public const int TipodescontoFieldNumber = 4;
    private int tipodesconto_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Tipodesconto {
      get { return tipodesconto_; }
      set {
        tipodesconto_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VoucherResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VoucherResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Percentual, other.Percentual)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Valordesconto, other.Valordesconto)) return false;
      if (Codigo != other.Codigo) return false;
      if (Tipodesconto != other.Tipodesconto) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Percentual != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Percentual);
      if (Valordesconto != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Valordesconto);
      if (Codigo.Length != 0) hash ^= Codigo.GetHashCode();
      if (Tipodesconto != 0) hash ^= Tipodesconto.GetHashCode();
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
      if (Percentual != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Percentual);
      }
      if (Valordesconto != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Valordesconto);
      }
      if (Codigo.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Codigo);
      }
      if (Tipodesconto != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Tipodesconto);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Percentual != 0D) {
        size += 1 + 8;
      }
      if (Valordesconto != 0D) {
        size += 1 + 8;
      }
      if (Codigo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Codigo);
      }
      if (Tipodesconto != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Tipodesconto);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VoucherResponse other) {
      if (other == null) {
        return;
      }
      if (other.Percentual != 0D) {
        Percentual = other.Percentual;
      }
      if (other.Valordesconto != 0D) {
        Valordesconto = other.Valordesconto;
      }
      if (other.Codigo.Length != 0) {
        Codigo = other.Codigo;
      }
      if (other.Tipodesconto != 0) {
        Tipodesconto = other.Tipodesconto;
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
          case 9: {
            Percentual = input.ReadDouble();
            break;
          }
          case 17: {
            Valordesconto = input.ReadDouble();
            break;
          }
          case 26: {
            Codigo = input.ReadString();
            break;
          }
          case 32: {
            Tipodesconto = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
