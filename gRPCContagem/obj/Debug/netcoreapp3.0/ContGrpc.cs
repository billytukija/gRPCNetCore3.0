// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/cont.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPCContagem {
  public static partial class ContadorSvc
  {
    static readonly string __ServiceName = "Cont.ContadorSvc";

    static readonly grpc::Marshaller<global::gRPCContagem.ContadorRequest> __Marshaller_Cont_ContadorRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCContagem.ContadorRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPCContagem.ContadorReply> __Marshaller_Cont_ContadorReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCContagem.ContadorReply.Parser.ParseFrom);

    static readonly grpc::Method<global::gRPCContagem.ContadorRequest, global::gRPCContagem.ContadorReply> __Method_GerarValor = new grpc::Method<global::gRPCContagem.ContadorRequest, global::gRPCContagem.ContadorReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GerarValor",
        __Marshaller_Cont_ContadorRequest,
        __Marshaller_Cont_ContadorReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPCContagem.ContReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ContadorSvc</summary>
    [grpc::BindServiceMethod(typeof(ContadorSvc), "BindService")]
    public abstract partial class ContadorSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::gRPCContagem.ContadorReply> GerarValor(global::gRPCContagem.ContadorRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ContadorSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GerarValor, serviceImpl.GerarValor).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ContadorSvcBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GerarValor, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCContagem.ContadorRequest, global::gRPCContagem.ContadorReply>(serviceImpl.GerarValor));
    }

  }
}
#endregion
