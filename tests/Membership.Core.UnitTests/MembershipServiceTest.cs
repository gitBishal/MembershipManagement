using AutoMapper;
using Membership.Application.Services;
using Membership.Application.ViewModels;
using Membership.Core.Interfaces;
using Moq;
using Xunit;


namespace Membership.Core.UnitTests
{
    public class MembershipServiceUnitTest
    {
        private readonly MembershipService _sut;
        private readonly Mock<IMembershipRepository> _membershipRepositoryMock = new Mock<IMembershipRepository>();
        private readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();

        public MembershipServiceUnitTest()
        {
            _sut = new MembershipService(_membershipRepositoryMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task GetMembershipById_ShouldReturnMembershipViewModel_WhenMembershipExists()
        {
            // Arrange
            var categoryID = Guid.NewGuid();
            var categoryName = "Test";
            var membership = new Entities.Membership
            {
                Id = categoryID,
                Name = categoryName,
                Description = "test",
                DiscountTypeId = Guid.NewGuid(),
                DiscountValue = "123"
            };

            var membershipViewModel = new MembershipViewModel
            {
                Name = categoryName,
                Description = "test",
                DiscountTypeId = Guid.NewGuid(),
                DiscountValue = "123"
            };

            _membershipRepositoryMock
                .Setup(x => x.GetAllMembershipsbyIDAsync(categoryID))
                .ReturnsAsync(membership);

            _mapperMock
                .Setup(x => x.Map<MembershipViewModel>(It.IsAny<Entities.Membership>()))
                .Returns(membershipViewModel);

            // Act
            var response = await _sut.GetAllMembershipsByIDAsync(categoryID);

            // Assert
            Xunit.Assert.NotNull(response);
            Xunit.Assert.Equal(categoryName, response.Name);
            Xunit.Assert.Equal("test", response.Description);
            Xunit.Assert.Equal("123", response.DiscountValue);
        }
    }
}