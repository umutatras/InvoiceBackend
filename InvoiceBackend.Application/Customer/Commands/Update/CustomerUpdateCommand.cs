using InvoiceBackend.Application.Models.General;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBackend.Application.Customer.Commands.Update;

public sealed class CustomerUpdateCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
    public string TaxNumber { get; set; }
    public string Title { get; set; }
    public string Address { get; set; }
    public string EMail { get; set; }
}
