// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/clientCount.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcClientCount {
  public static partial class ClientCountProvider
  {
    static readonly string __ServiceName = "ClientCountProvider";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcClientCount.ClientCount> __Marshaller_ClientCount = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcClientCount.ClientCount.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcClientCount.ClientCount> __Method_GetClientCount = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcClientCount.ClientCount>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetClientCount",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_ClientCount);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcClientCount.ClientCountReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ClientCountProvider</summary>
    [grpc::BindServiceMethod(typeof(ClientCountProvider), "BindService")]
    public abstract partial class ClientCountProviderBase
    {
      public virtual global::System.Threading.Tasks.Task GetClientCount(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::GrpcClientCount.ClientCount> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ClientCountProviderBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetClientCount, serviceImpl.GetClientCount).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ClientCountProviderBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetClientCount, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcClientCount.ClientCount>(serviceImpl.GetClientCount));
    }

  }
}
#endregion
