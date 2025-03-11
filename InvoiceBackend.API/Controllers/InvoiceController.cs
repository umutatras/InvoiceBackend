using InvoiceBackend.Application.Customer.Commands.Add;
using InvoiceBackend.Application.Customer.Commands.Delete;
using InvoiceBackend.Application.Customer.Commands.Update;
using InvoiceBackend.Application.Customer.Queries.GetAll;
using InvoiceBackend.Application.Invoice.Commands.Add;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceBackend.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InvoiceController : ApiControllerBase
{
    public InvoiceController(ISender mediatr) : base(mediatr)
    {
    }
    [HttpPost]
    public async Task<IActionResult> POST(InvoiceAddCommand command, CancellationToken cancellationToken)
    {
        return Ok(await Mediatr.Send(command, cancellationToken));
    }
    //[HttpPut]
    //public async Task<IActionResult> PUT(CustomerUpdateCommand command, CancellationToken cancellationToken)
    //{
    //    return Ok(await Mediatr.Send(command, cancellationToken));
    //}
    //[HttpDelete]
    //public async Task<IActionResult> DELETE(CustomerDeleteCommand command, CancellationToken cancellationToken)
    //{
    //    return Ok(await Mediatr.Send(command, cancellationToken));
    //}

    //[HttpGet]
    //public async Task<IActionResult> GET(CancellationToken cancellationToken)
    //{
    //    return Ok(await Mediatr.Send(new GetAllCustomerQuery(), cancellationToken));
    //}
}
