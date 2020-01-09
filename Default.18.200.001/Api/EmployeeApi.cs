using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class EmployeeApi : EntityAPI<Employee>
    {
        public EmployeeApi() : base()
        {
        }
        public EmployeeApi(Configuration configuration) : base(configuration)
        {
        }
    }
}
