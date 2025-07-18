using System;
using Core.Entities;

namespace Core.Specifications;

public class ProductSpecification(string? brand, string? type) : BaseSpecification<Product>(x =>
    (string.IsNullOrWhiteSpace(brand) || x.Brand == brand) &&
    (string.IsNullOrWhiteSpace(type) || x.Type == type)
  )
{
}
