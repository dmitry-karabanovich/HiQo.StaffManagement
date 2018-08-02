using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Xunit;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffMaangement.Domain.Test
{
    public class CategoryServiceTest
    {
        private readonly ICategoryRepository _category;
        private readonly ICategoryService _categoryService;

        public CategoryServiceTest()
        {
            _category = A.Fake<ICategoryRepository>();
            _categoryService = new CategoryService(_category);
        }

        [Fact]
        public void GetById()
        {
            const int categoryId = 1;
            var category = new CategoryDto() { CategoryDtoId = categoryId };
            A.CallTo(() => _category.GetById<CategoryDto>(categoryId)).Returns(category);

            var returnsUser = _categoryService.GetById(categoryId);

            Assert.Equal(categoryId, returnsUser.CategoryDtoId);
        }

        [Fact]
        public void GetAll()
        {
            IEnumerable<CategoryDto> categories = new CategoryDto[] { new CategoryDto() { CategoryDtoId = 1 }, new CategoryDto() { CategoryDtoId = 2 } };
            var expectedIds = new[] { 1, 2 };
            A.CallTo(() => _category.GetAll<CategoryDto>()).Returns(categories);

            var expectedcategories = _categoryService.GetAll().ToList();

            Assert.Equal(expectedIds.Length, expectedcategories.Count);

            for (var i = 0; i < expectedIds.Length; i++)
            {
                Assert.Equal(expectedcategories[i].CategoryDtoId, expectedIds[i]);
            }
        }
    }
}
