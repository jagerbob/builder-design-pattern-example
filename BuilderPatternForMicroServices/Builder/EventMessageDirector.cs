using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Builder
{
    public class EventMessageDirector
    {
        private readonly IEventMessageBuilder _builder;

        public EventMessageDirector(IEventMessageBuilder builder)
        {
            _builder = builder;
        }

        public void BuildServiceStartupEvent()
        {
            _builder.Reset();
            _builder.WithId(Guid.NewGuid());
            _builder.WithCorrelationId(Guid.NewGuid());
            _builder.WithChannel("SERVICE_STATUS");
            _builder.WithTimestamp(DateTime.Now);
            _builder.WithEventType("SERVICE_STARTUP");
        }

        public void BuildServiceShutdownEvent()
        {
            _builder.Reset();
            _builder.WithId(Guid.NewGuid());
            _builder.WithCorrelationId(Guid.NewGuid());
            _builder.WithChannel("SERVICE_STATUS");
            _builder.WithTimestamp(DateTime.Now);
            _builder.WithEventType("SERVICE_SHUTDOWN");
        }
    }
}
