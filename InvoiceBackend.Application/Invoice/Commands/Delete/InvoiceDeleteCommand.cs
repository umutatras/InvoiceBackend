using InvoiceBackend.Application.Models.General;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBackend.Application.Invoice.Commands.Delete;

public sealed class InvoiceDeleteCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
}
