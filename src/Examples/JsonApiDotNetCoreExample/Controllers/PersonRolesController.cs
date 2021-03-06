using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using JsonApiDotNetCoreExample.Models;
using Microsoft.Extensions.Logging;

namespace JsonApiDotNetCoreExample.Controllers
{
    public sealed class PersonRolesController : JsonApiController<PersonRole>
    {
        public PersonRolesController(
            IJsonApiOptions options,
            ILoggerFactory loggerFactory,
            IResourceService<PersonRole> resourceService)
            : base(options, loggerFactory, resourceService)
        { }
    }
}
