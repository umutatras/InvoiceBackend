using FluentValidation;
using InvoiceBackend.Application.Invoice.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBackend.Application.Invoice.Commands.Update;

public class InvoiceUpdateCommandValidator : AbstractValidator<InvoiceUpdateCommand>
{
    public InvoiceUpdateCommandValidator()
    {
        RuleFor(x => x.CustomerId)
            .NotEmpty()
            .WithMessage("CustomerId is not null");
    }
}
