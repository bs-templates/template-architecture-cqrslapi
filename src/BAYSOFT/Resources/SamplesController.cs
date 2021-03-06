﻿using BAYSOFT.Abstractions.Controllers;
using BAYSOFT.Core.Application.Default.Samples.Commands.DeleteSample;
using BAYSOFT.Core.Application.Default.Samples.Commands.PatchSample;
using BAYSOFT.Core.Application.Default.Samples.Commands.PostSample;
using BAYSOFT.Core.Application.Default.Samples.Commands.PutSample;
using BAYSOFT.Core.Application.Default.Samples.Queries.GetSampleById;
using BAYSOFT.Core.Application.Default.Samples.Queries.GetSamplesByFilter;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace BAYSOFT.Resources
{
    public class SamplesController : ResourceController
    {
        [HttpGet]
        public async Task<ActionResult<GetSamplesByFilterQueryResponse>> Get(GetSamplesByFilterQuery request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await Mediator.Send(request, cancellationToken);
        }

        [HttpGet("{sampleid}")]
        public async Task<ActionResult<GetSampleByIdQueryResponse>> Get(GetSampleByIdQuery request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await Mediator.Send(request, cancellationToken);
        }

        [HttpPost]
        public async Task<ActionResult<PostSampleCommandResponse>> Post(PostSampleCommand request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await Mediator.Send(request, cancellationToken);
        }

        [HttpPut("{sampleid}")]
        public async Task<ActionResult<PutSampleCommandResponse>> Put(PutSampleCommand request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await Mediator.Send(request, cancellationToken);
        }

        [HttpPatch("{sampleid}")]
        public async Task<ActionResult<PatchSampleCommandResponse>> Patch(PatchSampleCommand request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await Mediator.Send(request, cancellationToken);
        }

        [HttpDelete("{sampleid}")]
        public async Task<ActionResult<DeleteSampleCommandResponse>> Delete(DeleteSampleCommand request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await Mediator.Send(request, cancellationToken);
        }
    }
}
