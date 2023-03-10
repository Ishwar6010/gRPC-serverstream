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

    /// <summary>Client for ClientCountProvider</summary>
    public partial class ClientCountProviderClient : grpc::ClientBase<ClientCountProviderClient>
    {
      /// <summary>Creates a new client for ClientCountProvider</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ClientCountProviderClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ClientCountProvider that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ClientCountProviderClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ClientCountProviderClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ClientCountProviderClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::GrpcClientCount.ClientCount> GetClientCount(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetClientCount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcClientCount.ClientCount> GetClientCount(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetClientCount, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ClientCountProviderClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ClientCountProviderClient(configuration);
      }
    }

  }
}
#endregion
