using System;
using System.Collections.Generic;
public interface IOrder
{
     int GetTotalPrice(List<Product> products);
}