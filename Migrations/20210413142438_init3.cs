using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTalk.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CoverUrl", "Created", "Description", "IsFeatured", "IsVisible", "Price", "Sale", "Stock", "Title" },
                values: new object[,]
                {
                    { "61c78844-ae99-4210-a4a9-0f74f32f9ed4", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7868/9781786892737.jpg", new DateTime(2021, 4, 13, 16, 24, 37, 109, DateTimeKind.Local).AddTicks(1905), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, false, 100.0, 0, 10, "The Midnight Library" },
                    { "7b08ec5b-223c-4b83-90af-a0b34962129f", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5266/9781526612168.jpg", new DateTime(2021, 4, 13, 16, 24, 37, 110, DateTimeKind.Local).AddTicks(3239), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, false, 100.0, 0, 10, "Such a Fun Age : 'The book of the year' Independent" },
                    { "376282ce-65e9-420d-942a-41968f36008a", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/8460/9781846045127.jpg", new DateTime(2021, 4, 13, 16, 24, 37, 110, DateTimeKind.Local).AddTicks(3422), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", true, true, 50.0, 50, 10, "The Choice : A true story of hope" },
                    { "075c9e87-3140-4c5c-955f-7e3f54ebe23f", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/2419/9780241982976.jpg", new DateTime(2021, 4, 13, 16, 24, 37, 110, DateTimeKind.Local).AddTicks(3499), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", true, true, 120.0, 10, 10, "Becoming : The Sunday Times Number One Bestseller" },
                    { "05206d4d-2e17-407f-8c6a-ae6af451ae34", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/8479/9781847941831.jpg", new DateTime(2021, 4, 13, 16, 24, 37, 110, DateTimeKind.Local).AddTicks(3566), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, true, 175.0, 20, 10, "Atomic Habits : the life-changing million-copy #1 bestseller" },
                    { "0f2843bf-a707-406f-8909-2476d54d10c3", "https://image.bokus.com/images/9781544512266_200x_cant-hurt-me_e-bok", new DateTime(2021, 4, 13, 16, 24, 37, 110, DateTimeKind.Local).AddTicks(3639), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", false, true, 245.0, 20, 10, "Can't Hurt Me" }
                });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "MenuOrder", "Title" },
                values: new object[,]
                {
                    { "1d8ae159-9832-401f-9454-39dca4083359", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 13, 16, 24, 37, 101, DateTimeKind.Local).AddTicks(8558), "", true, true, 100, "About" },
                    { "82ff13fa-bdc3-4792-bd24-4bd558ec8ecf", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 13, 16, 24, 37, 108, DateTimeKind.Local).AddTicks(8934), "", false, true, 100, "FAQ" },
                    { "a4f3b0f9-217c-44b1-b43c-a38153bfef0a", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 13, 16, 24, 37, 108, DateTimeKind.Local).AddTicks(9092), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", true, true, 100, "Contact" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0a880cc1-659a-4635-be2a-eef833e2096a",
                column: "ConcurrencyStamp",
                value: "99820837-a405-48e7-a70a-873145099f5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "46e8fe91-21d2-49bf-8607-bebd2c1d810a",
                column: "ConcurrencyStamp",
                value: "fb10ba2b-2e7c-48b3-a07c-48e6299aeaa9");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "05206d4d-2e17-407f-8c6a-ae6af451ae34");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "075c9e87-3140-4c5c-955f-7e3f54ebe23f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0f2843bf-a707-406f-8909-2476d54d10c3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "376282ce-65e9-420d-942a-41968f36008a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "61c78844-ae99-4210-a4a9-0f74f32f9ed4");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "7b08ec5b-223c-4b83-90af-a0b34962129f");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "1d8ae159-9832-401f-9454-39dca4083359");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "82ff13fa-bdc3-4792-bd24-4bd558ec8ecf");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "a4f3b0f9-217c-44b1-b43c-a38153bfef0a");

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0a880cc1-659a-4635-be2a-eef833e2096a",
                column: "ConcurrencyStamp",
                value: "cc46baf9-8b1d-426a-a45c-9f2ec6a33f9b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "46e8fe91-21d2-49bf-8607-bebd2c1d810a",
                column: "ConcurrencyStamp",
                value: "8d36120f-5414-4af8-b3c0-445c20cf379a");
        }
    }
}
