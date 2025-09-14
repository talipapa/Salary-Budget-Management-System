using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Salaries;

public record Money(string Currency, decimal Amount);
