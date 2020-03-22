using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_17_200_001.Model;

namespace Acumatica.Default_17_200_001.Api
{
	public class TaskRelatedActivityApi : EntityAPI<TaskRelatedActivity>
	{
		public TaskRelatedActivityApi(Configuration configuration) : base(configuration)
		{ }
	}
}