﻿using InvoiceBackend.Application.Auth.Commands.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingBackend.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ApiControllerBase
{
    public AuthController(ISender mediator) : base(mediator)
    {

    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login(AuthLoginCommand command)
    {
        return Ok(await Mediatr.Send(command));
    }

  //  [HttpPost("register")]
  //  public async Task<IActionResult> Register(AuthRegisterCommand command, CancellationToken cancellationToken)
  //  {
  //      return Ok(await Mediatr.Send(command, cancellationToken));
  //  }

  //  [HttpPost("refresh-token")]
  //  public async Task<IActionResult> RefreshToken(AuthRefreshTokenCommand command, CancellationToken cancellationToken)
  //=> Ok(await Mediatr.Send(command, cancellationToken));
}