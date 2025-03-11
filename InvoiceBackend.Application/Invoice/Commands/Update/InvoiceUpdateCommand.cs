using InvoiceBackend.Application.Models.General;
using InvoiceBackend.Application.Models.Invoice;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBackend.Application.Invoice.Commands.Update;

public class InvoiceUpdateCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public decimal TotalAmount { get; set; }
    public List<InvoiceUpdateRequestDto> InvoiceLines { get; set; } = new List<InvoiceUpdateRequestDto>();
}
