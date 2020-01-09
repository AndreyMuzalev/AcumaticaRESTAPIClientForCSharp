using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class InvoiceApi : EntityAPI<Invoice>
    {
        public InvoiceApi() : base()
        {
        }
        public InvoiceApi(Configuration configuration) : base(configuration)
        {
        }
    }
}
