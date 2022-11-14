﻿using Application.Interfaces.Repositories;
using Domain.Entities;
using Domain.ViewModel.Categorys;
using MediatR;

namespace Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesQuery : IRequest<IEnumerable<CategoryVM>>
    {
        public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<CategoryVM>>
        {
            private readonly ICategoryRepository _categoryRepository;

            public GetAllCategoriesQueryHandler(ICategoryRepository categoryRepository)
            {
                _categoryRepository = categoryRepository;
            }

            public async Task<IEnumerable<CategoryVM>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
            {
                var categoryList = await _categoryRepository.GetAllCategory();
                return categoryList; 
            }
        }
    }
}