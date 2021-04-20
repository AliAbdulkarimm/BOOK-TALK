using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTalk.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "064676db-e8fc-4c6f-be92-972138a441c5");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "60d0a92e-f1eb-44de-b76c-aad01ca197b0");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "89db5c1f-e6c7-4b6a-8720-7c60718a3918");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "cafeaa59-2435-44d2-9721-a3960bbabe3f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ecb5db63-9b74-4a14-b459-5099c24fd684");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "f725b0bf-4dda-4b7d-9068-3799c95dcea6");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "32a3ff6c-e582-4a06-ab4b-55b1ede4bf9e");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "4ea238ea-7c9b-4328-a376-bbd95e0da527");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "5380b3ae-3c69-41fa-80df-1f18a19f5dbf");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8d51f74b-d869-429c-b6a2-f7d68dd72933");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b9cee6ee-0c47-4f75-8326-7d8ae18b6a3f");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "UserOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CoverUrl", "Created", "Description", "IsFeatured", "IsVisible", "Price", "Sale", "Stock", "Title" },
                values: new object[,]
                {
                    { "c395fe99-0f33-46b0-b348-c5c1d8d2207c", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7868/9781786892737.jpg", new DateTime(2021, 4, 13, 15, 42, 55, 711, DateTimeKind.Local).AddTicks(3434), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, false, 100.0, 0, 10, "The Midnight Library" },
                    { "1aafc542-7ede-492c-894f-e432521a01d6", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5266/9781526612168.jpg", new DateTime(2021, 4, 13, 15, 42, 55, 712, DateTimeKind.Local).AddTicks(3030), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, false, 100.0, 0, 10, "Such a Fun Age : 'The book of the year' Independent" },
                    { "38e2cf88-7049-40b9-beeb-5c7b99acab70", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/8460/9781846045127.jpg", new DateTime(2021, 4, 13, 15, 42, 55, 712, DateTimeKind.Local).AddTicks(3165), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", true, true, 50.0, 50, 10, "The Choice : A true story of hope" },
                    { "2e03b767-637b-4d60-97ea-e061f5ae6a2e", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/2419/9780241982976.jpg", new DateTime(2021, 4, 13, 15, 42, 55, 712, DateTimeKind.Local).AddTicks(3237), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", true, true, 120.0, 10, 10, "Becoming : The Sunday Times Number One Bestseller" },
                    { "4c603798-5f85-40aa-be7f-7d12f04e6630", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/8479/9781847941831.jpg", new DateTime(2021, 4, 13, 15, 42, 55, 712, DateTimeKind.Local).AddTicks(3291), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, true, 175.0, 20, 10, "Atomic Habits : the life-changing million-copy #1 bestseller" },
                    { "0edcc82a-0ff3-4934-9d1d-14ecaf3184b2", "https://image.bokus.com/images/9781544512266_200x_cant-hurt-me_e-bok", new DateTime(2021, 4, 13, 15, 42, 55, 712, DateTimeKind.Local).AddTicks(3349), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, true, 245.0, 20, 10, "Can't Hurt Me" }
                });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "MenuOrder", "Title" },
                values: new object[,]
                {
                    { "efcbf753-6be8-4928-9438-56cccf6a7b3d", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 13, 15, 42, 55, 705, DateTimeKind.Local).AddTicks(333), "", true, true, 100, "About" },
                    { "df3b74c5-9ffc-4612-acbb-bc6133d9007f", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 13, 15, 42, 55, 711, DateTimeKind.Local).AddTicks(416), "", false, true, 100, "FAQ" },
                    { "4f2bfb1f-c5c4-4529-aa21-d5edd67cc3dd", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 13, 15, 42, 55, 711, DateTimeKind.Local).AddTicks(573), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", true, true, 100, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a880cc1-659a-4635-be2a-eef833e2096a", "cc46baf9-8b1d-426a-a45c-9f2ec6a33f9b", "Admin", "ADMIN" },
                    { "46e8fe91-21d2-49bf-8607-bebd2c1d810a", "8d36120f-5414-4af8-b3c0-445c20cf379a", "Customer", "CUSTOMER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0edcc82a-0ff3-4934-9d1d-14ecaf3184b2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "1aafc542-7ede-492c-894f-e432521a01d6");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "2e03b767-637b-4d60-97ea-e061f5ae6a2e");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "38e2cf88-7049-40b9-beeb-5c7b99acab70");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4c603798-5f85-40aa-be7f-7d12f04e6630");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "c395fe99-0f33-46b0-b348-c5c1d8d2207c");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "4f2bfb1f-c5c4-4529-aa21-d5edd67cc3dd");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "df3b74c5-9ffc-4612-acbb-bc6133d9007f");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "efcbf753-6be8-4928-9438-56cccf6a7b3d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0a880cc1-659a-4635-be2a-eef833e2096a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "46e8fe91-21d2-49bf-8607-bebd2c1d810a");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "UserOrders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SecondAddress",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CoverUrl", "Created", "Description", "IsFeatured", "IsVisible", "Price", "Sale", "Stock", "Title" },
                values: new object[,]
                {
                    { "cafeaa59-2435-44d2-9721-a3960bbabe3f", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7868/9781786892737.jpg", new DateTime(2021, 4, 12, 20, 16, 42, 480, DateTimeKind.Local).AddTicks(937), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, false, 100.0, 0, 10, "The Midnight Library" },
                    { "064676db-e8fc-4c6f-be92-972138a441c5", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5266/9781526612168.jpg", new DateTime(2021, 4, 12, 20, 16, 42, 480, DateTimeKind.Local).AddTicks(7440), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, false, 100.0, 0, 10, "Such a Fun Age : 'The book of the year' Independent" },
                    { "ecb5db63-9b74-4a14-b459-5099c24fd684", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/8460/9781846045127.jpg", new DateTime(2021, 4, 12, 20, 16, 42, 480, DateTimeKind.Local).AddTicks(7503), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", true, true, 50.0, 50, 10, "The Choice : A true story of hope" },
                    { "60d0a92e-f1eb-44de-b76c-aad01ca197b0", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/2419/9780241982976.jpg", new DateTime(2021, 4, 12, 20, 16, 42, 480, DateTimeKind.Local).AddTicks(7537), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", true, true, 120.0, 10, 10, "Becoming : The Sunday Times Number One Bestseller" },
                    { "f725b0bf-4dda-4b7d-9068-3799c95dcea6", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/8479/9781847941831.jpg", new DateTime(2021, 4, 12, 20, 16, 42, 480, DateTimeKind.Local).AddTicks(7585), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, true, 175.0, 20, 10, "Atomic Habits : the life-changing million-copy #1 bestseller" },
                    { "89db5c1f-e6c7-4b6a-8720-7c60718a3918", "https://image.bokus.com/images/9781544512266_200x_cant-hurt-me_e-bok", new DateTime(2021, 4, 12, 20, 16, 42, 480, DateTimeKind.Local).AddTicks(7626), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, true, 245.0, 20, 10, "Can't Hurt Me" }
                });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "MenuOrder", "Title" },
                values: new object[,]
                {
                    { "4ea238ea-7c9b-4328-a376-bbd95e0da527", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 12, 20, 16, 42, 475, DateTimeKind.Local).AddTicks(7859), "", true, true, 100, "About" },
                    { "5380b3ae-3c69-41fa-80df-1f18a19f5dbf", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 12, 20, 16, 42, 479, DateTimeKind.Local).AddTicks(8875), "", false, true, 100, "FAQ" },
                    { "32a3ff6c-e582-4a06-ab4b-55b1ede4bf9e", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 12, 20, 16, 42, 479, DateTimeKind.Local).AddTicks(8972), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", true, true, 100, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d51f74b-d869-429c-b6a2-f7d68dd72933", "1348ed1d-67ba-40e8-bcfa-ed02d699da9a", "Admin", "ADMIN" },
                    { "b9cee6ee-0c47-4f75-8326-7d8ae18b6a3f", "acc7ccf8-d2d1-491c-8f0c-b8e6499ec7fa", "Customer", "CUSTOMER" }
                });
        }
    }
}
