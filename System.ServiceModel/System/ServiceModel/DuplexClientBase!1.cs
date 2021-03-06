﻿namespace System.ServiceModel
{
    using System;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Description;

    public abstract class DuplexClientBase<TChannel> : ClientBase<TChannel> where TChannel: class
    {
        protected DuplexClientBase(object callbackInstance) : this(new InstanceContext(callbackInstance))
        {
        }

        protected DuplexClientBase(InstanceContext callbackInstance) : base(callbackInstance)
        {
        }

        protected DuplexClientBase(object callbackInstance, ServiceEndpoint endpoint) : this(new InstanceContext(callbackInstance), endpoint)
        {
        }

        protected DuplexClientBase(object callbackInstance, string endpointConfigurationName) : this(new InstanceContext(callbackInstance), endpointConfigurationName)
        {
        }

        protected DuplexClientBase(InstanceContext callbackInstance, ServiceEndpoint endpoint) : base(callbackInstance, endpoint)
        {
        }

        protected DuplexClientBase(InstanceContext callbackInstance, string endpointConfigurationName) : base(callbackInstance, endpointConfigurationName)
        {
        }

        protected DuplexClientBase(object callbackInstance, Binding binding, EndpointAddress remoteAddress) : this(new InstanceContext(callbackInstance), binding, remoteAddress)
        {
        }

        protected DuplexClientBase(object callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress) : this(new InstanceContext(callbackInstance), endpointConfigurationName, remoteAddress)
        {
        }

        protected DuplexClientBase(object callbackInstance, string endpointConfigurationName, string remoteAddress) : this(new InstanceContext(callbackInstance), endpointConfigurationName, remoteAddress)
        {
        }

        protected DuplexClientBase(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress) : base(callbackInstance, binding, remoteAddress)
        {
        }

        protected DuplexClientBase(InstanceContext callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress) : base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        protected DuplexClientBase(InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        protected override TChannel CreateChannel()
        {
            return base.ChannelFactory.CreateChannel();
        }

        public IDuplexContextChannel InnerDuplexChannel
        {
            get
            {
                return (IDuplexContextChannel) base.InnerChannel;
            }
        }
    }
}

