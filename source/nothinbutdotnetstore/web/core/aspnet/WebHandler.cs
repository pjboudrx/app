﻿using System;
using System.Web;

namespace nothinbutdotnetstore.web.core.aspnet
{
    public class WebHandler:IHttpHandler
    {
        IProcessRequests front_controller;
        ICreateRequests request_factory;

        public WebHandler(IProcessRequests front_controller, ICreateRequests request_factory)
        {
            this.front_controller = front_controller;
            this.request_factory = request_factory;
        }

        public void ProcessRequest(HttpContext context)
        {
        	var request = request_factory.create_request_from(context);
			front_controller.process(request);
        }

        public bool IsReusable
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}