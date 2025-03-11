﻿using InvoiceBackend.Application.Auth.Commands.Register;
using InvoiceBackend.Application.Customer.Commands.Add;
using InvoiceBackend.Application.Customer.Commands.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceBackend.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ApiControllerBase
{
    public CustomerController(ISender mediatr) : base(mediatr)
    {
    }
    [HttpPost]
    public async Task<IActionResult> POST(CustomerAddCommand command, CancellationToken cancellationToken)
    {
        return Ok(await Mediatr.Send(command, cancellationToken));
    }
    [HttpPut]
    public async Task<IActionResult> PUT(CustomerUpdateCommand command, CancellationToken cancellationToken)
    {
        return Ok(await Mediatr.Send(command, cancellationToken));
    }
}
