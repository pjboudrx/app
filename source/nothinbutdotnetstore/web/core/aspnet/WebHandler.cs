﻿using System.Web;
using nothinbutdotnetstore.web.application.catalogbrowsing.stubs;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.core.aspnet
{
    public class WebHandler : IHttpHandler
    {
        IProcessRequests front_controller;
        ICreateRequests request_factory;

        public WebHandler():this(new FrontController(), Stub.with<StubRequestFactory>())
        {
        }

        public WebHandler(IProcessRequests front_controller, ICreateRequests request_factory)
        {
            this.front_controller = front_controller;
            this.request_factory = request_factory;
        }

        public void ProcessRequest(HttpContext context)
        {
            this.front_controller.process(this.request_factory.create_request_from(context));
        }

        public bool IsReusable
        {
            get { return true; }
        }
    }
}