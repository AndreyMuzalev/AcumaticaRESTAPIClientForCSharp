using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class CompleteAndFollowUpEvent : EntityAction<Event>
	{
		public CompleteAndFollowUpEvent(Event entity) : base(entity)
		{ }
		public CompleteAndFollowUpEvent() : base()
		{ }
	}
}
