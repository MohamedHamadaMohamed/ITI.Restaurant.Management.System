using RMS.Presentation.Layer.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries.AdminQueries
{
    public class AdminGetCategoryByIdQuery : GetCategoryByIdQuery<AdminCategoryDto>
    {
        public AdminGetCategoryByIdQuery(int id) : base(id)
        {
        }
    }
}
