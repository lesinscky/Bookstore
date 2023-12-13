﻿using FluentValidation;

namespace Bookstore.Domain.Dtos.v1.Request.Book;

public class UpdateBookDtoValidator : AbstractValidator<UpdateBookDto>
{
    public UpdateBookDtoValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Pages).GreaterThan(0);
        RuleFor(x => x.Year).GreaterThan(-5000);
        RuleFor(x => x.Status).NotNull().NotEmpty();
        RuleFor(x => x.Author).NotNull().NotEmpty();
        RuleFor(x => x.Genre).NotNull().NotEmpty();
        RuleFor(x => x.Publisher).NotNull().NotEmpty();
        RuleFor(x => x.Title).NotNull().NotEmpty();
    }
}