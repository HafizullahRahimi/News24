﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using News24.Data.Context;

#nullable disable

namespace News24.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240512110702_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7c9e6679-7425-40de-944b-e07fc1f90ae7",
                            ConcurrencyStamp = "7c9e6679-7425-40de-944b-e07fc1f90ae7",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "78ad125d-50c7-4732-8e6c-6c4eaa93ffd3",
                            ConcurrencyStamp = "78ad125d-50c7-4732-8e6c-6c4eaa93ffd3",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "7b4760ea-fc19-4030-9502-191c3e3426d9",
                            ConcurrencyStamp = "7b4760ea-fc19-4030-9502-191c3e3426d9",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0f8fad5b-d9cb-469f-a165-70867728950e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "68b30b11-3916-430e-ba2a-f616ae59a5c6",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFpkSWYCDi+XEI44U9cvtOkhmOMVWdSLOnhzciO0FByZxLqrPiVtuA1OQQrWMkDpJg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "92fb5cf0-7e41-4fda-92c3-3de47a0e9fbe",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "0f8fad5b-d9cb-469f-a165-70867728950e",
                            RoleId = "7c9e6679-7425-40de-944b-e07fc1f90ae7"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("News24.Data.Entities.NewsEntities.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("NewsId");

                    b.ToTable("Newses");

                    b.HasData(
                        new
                        {
                            NewsId = 1,
                            CreateDate = new DateTime(2024, 5, 12, 13, 7, 2, 513, DateTimeKind.Local).AddTicks(3264),
                            CreatedBy = "0f8fad5b-d9cb-469f-a165-70867728950e",
                            Description = "<p style=\"margin-right:0px;\">«سرهی رود» از سال ۲۰۱۹ فرماندهی تیم محافظت از رئیس‌جمهوری را بر عهده داشته است. نهاد ریاست جمهوری در حکمی کوتاه برکناری آقای «رود» را اعلام کرده اما دلیل آن را ذکر نکرده است.</p><p style=\"margin-right:0px;\">دو سرهنگ عضو گارد دولتی که روز سه‌شنبه بازداشت شدند، به عضویت در شبکه‌ای از جاسوسان متهم هستند که از سوی سرویس امنیت فدرال روسیه (FSB) مدیریت می‌شود.</p><p><br>آقای زلنسکی در گذشته از تلاش مکرر روسیه برای سو‌ء قصد به جانش صحبت کرده است، اما اتهام اخیر متوجه نیروهای شخصی همراه او است. در این نقشه همچنین دو مقام ارشد دیگر هدف قرار گرفته بود؛ «کریلو بودانف» فرمانده اطلاعات ارتش و «واسیل مالیوک» فرمانده سرویس امنیت دولتی.</p><p style=\"margin-right:0px;\">آقای مالیوک چند روز پیش گفت این نقشه قرار بوده به عنوان «هدیه به پوتین» پیش از پنجمین دوره ریاست جمهوری‌اش به نقطه اوج خود برسد.</p>",
                            ImageName = "news1.jpg",
                            IsActive = false,
                            ShortDescription = "ولودیمیر زلنسکی، رئیس جمهوری اوکراین، پس از آنکه دو مقام ارشد تیم محافظان شخصی‌اش به اتهام طرح نقشه برای سوء قصد او دستگیر شدند، فرمانده این تیم را برکنار کرده است.",
                            Title = "ولودیمیر زلنسکی فرمانده محافظان خود را اخراج کرد"
                        },
                        new
                        {
                            NewsId = 2,
                            CreateDate = new DateTime(2024, 5, 12, 13, 7, 2, 513, DateTimeKind.Local).AddTicks(3319),
                            CreatedBy = "0f8fad5b-d9cb-469f-a165-70867728950e",
                            Description = "<p style=\"margin-right:0px;\">این ویدیو رهبران ارشد حزب کنگره – حزب اصلی مخالف - را به تصویر می‌کشد که با محروم کردن اعضای جوامع کاست‌های فرودست و قبایل هند، امکانات دولتی را در اختیار مسلمانان قرار می‌دهند.</p><p style=\"margin-right:0px;\">ساعاتی پس از به جریان افتادن پرونده توسط پلیس، کمیسیون نظارت بر انتخابات هند از ایکس (توییتر سابق) خواست این پست ویدیویی را حذف کند.</p><p style=\"margin-right:0px;\">به گفته کمیسیون، این پست قوانین هند را نقض کرده است.</p><p style=\"margin-right:0px;\">هنوز ایکس یا حزب بهاراتیا جاناتا به درخواست کمیسیون یا گشودن این پرونده واکنشی نشان نداده‌اند.</p><p style=\"margin-right:0px;\">رای‌گیری انتخاباتی در کارناتاکا روز سه‌شنبه برگزار شد و در اوایل عصر به وقت محلی پایان یافت.</p><p style=\"margin-right:0px;\">این دومین ویدیویی است که بهاراتیا جاناتا طی دو هفته گذشته به صورت آنلاین منتشر کرده است.</p><p style=\"margin-right:0px;\">نارندرا مودی، نخست وزیر نیز ادعاهای مشابهی در این مورد مطرح کرده که احزاب مخالف در تجمع‌های انتخاباتی در صدد جلب حمایت مسلمانان بوده و به آنها وعده امتیازاتی بیش از سایر جوامع اقلیت داده‌اند.</p><p style=\"margin-right:0px;\">رای‌گیری در انتخابات پارلمانی هند چند هفته پیش آغاز شده است و در ماه ژوئن به پایان می‌رسد. مقررات انتخاباتی احزاب و رهبران سیاسی را از بهره‌برداری از گرایش‌های مذهبی و قومی برای کسب رای منع کرده است.</p><p style=\"margin-right:0px;\">اما رهبران احزاب مخالف و مفسران سیاسی گفته‌اند که آقای مودی که به‌دنبال سومین دوره نخست وزیری است، همراه با دیگر رهبران حزب ملیگرای هندو بهاراتیا جاناتا آشکارا به اسلام‌هراسی متوسل می‌شوند.</p><p style=\"margin-right:0px;\">این احزاب از کمیسیون انتخابات به خاطر عدم اقدام به موقع علیه حزب حاکم انتقاد کرده‌اند.</p><p style=\"margin-right:0px;\">جمعیت دویست میلیونی مسلمانان در هند بزرگترین اقلیت این کشور را تشکیل می‌دهد. از زمان به قدرت رسیدن حزب بهاراتیا جاناتا در سال ۲۰۱۴، اظهارات مخالف مسلمانان و نفرت‌پراکنی علیه آنها افزایش یافته است.</p><p style=\"margin-right:0px;\">این ویدئو روز ۴ مه در صفحه رسانه اجتماعی شعبه حزب حاکم با عنوان مراقب باشید... مراقب باشید... مراقب باشید...!» به زبان کنادا که زبان این ایالت جنوبی، است منتشر شد. این پست بیش از نه میلیون بار در ایکس دیده شده است.</p>",
                            ImageName = "news2.jpg",
                            IsActive = false,
                            ShortDescription = "پلیس هند پرونده شکایت علیه رهبران ارشد حزب حاکم بهاراتیا جاناتا را در ارتباط با پستی در شبکه‌های اجتماعی به جریان انداخته است. به گفته رهبران احزاب مخالف دولت، این پست وجهه مسلمانان را تخریب کرده و از آنان چهره‌ای خبیث به نمایش می‌گذارد.",
                            Title = "احزاب مخالف دولت در هند نارندرا مودی را به ایجاد بدبینی نسبت به مسلمانان متهم می‌کنند"
                        },
                        new
                        {
                            NewsId = 3,
                            CreateDate = new DateTime(2024, 5, 12, 13, 7, 2, 513, DateTimeKind.Local).AddTicks(3322),
                            CreatedBy = "0f8fad5b-d9cb-469f-a165-70867728950e",
                            Description = "<p style=\"margin-right:0px;\">شرکت آمریکایی اینتل به درخواست بی‌بی‌سی برای اظهارنظر در این باره پاسخ نداد. بی‌بی‌سی همچنین با هواوی و شرکت بزرگ تراشه‌سازی کوالکام در سن‌دیه‌گو تماس گرفته است تا واکنششان به این خبر را بداند.</p><p style=\"margin-right:0px;\">آمریکا در سال‌های اخیر با ارجاع به پیوندهای ادعایی هواوی با ارتش چین محدودیت‌هایی بر صادرات فناوری به این شرکت وضع کرده است.</p><p style=\"margin-right:0px;\">به دنبال رونمایی هواوی از لپتاپ متابوک ایکس پرو، برخی از اعضای کنگره آمریکا از دولت جو بایدن انتقاد کرده‌اند.</p><p style=\"margin-right:0px;\">الیز استفانیک، عضو جمهوری‌خواه کنگره، دولت آقای بایدن را متهم کرده است که اگر اقدام جمهوری‌خواهان نبود، محدودیت جدید علیه هواوی را وضع نمی‌کرد.</p><p style=\"margin-right:0px;\">هواوی به رغم محدودیت‌هایی که از طرف آمریکا متحمل شده به گسترش فعالیت‌هایش ادامه داده و به نظر می‌رسد که با رونمایی از گوشی جدیدش در ماه اوت گذشته شاهد رشد بوده است.</p><p style=\"margin-right:0px;\">از زمان ریاست جمهوری دونالد ترامپ هواوی جزو شرکت‌هایی است که صادرات برخی فناوری‌ها به آن به مجوز دولت نیاز دارد.</p><p style=\"margin-right:0px;\">تاکنون شرکت‌هایی چون اینتل و کوالکام مجوز فروش فناوری‌هایی به هواوی را داشتند، که البته فناوری 5G از آن مستثنی بود.</p><p style=\"margin-right:0px;\">آمریکا و چین شرکای مالی و تجاری بزرگی هستند، اما در سال‌های اخیر به طور فزاینده رقابت اقتصادی آنها تنش‌آمیز بوده و آمریکا تحریم‌های سختگیرانه‌ای علیه برخی شرکت‌های چینی وضع کرده است.</p><p style=\"margin-right:0px;\">به تازگی جو بایدن قانونی را امضا کرد که بالقوه می‌تواند به ممنوعیت تیک‌تاک یا اجبار مالک چینی به فروش آن منجر شود.</p><p style=\"margin-right:0px;\">در مقابل، روز سه‌شنبه شرکت چینی سازنده تیک تاک به منظور جلوگیری از اجرای این قانون از دولت آمریکا به طور رسمی شکایت کرده است.</p>",
                            ImageName = "news3.jpg",
                            IsActive = false,
                            ShortDescription = "وزارت بازرگانی آمریکا مشخص نکرده است که چه مجوزهایی لغو شده‌اند. این اقدام پس از آن انجام شد که هواوی از کامپیوتری با قابلیت‌های هوش مصنوعی رونمایی کرد که در آن از تراشه ساخت اینتل استفاده شده است.",
                            Title = "آمریکا مجوز صادرات تراشه به هواوی را لغو کرد"
                        },
                        new
                        {
                            NewsId = 4,
                            CreateDate = new DateTime(2024, 5, 12, 13, 7, 2, 513, DateTimeKind.Local).AddTicks(3323),
                            CreatedBy = "0f8fad5b-d9cb-469f-a165-70867728950e",
                            Description = "<p style=\"margin-right:0px;\">این درحالی است که قیمت تراشه‌ها پس از رکودی که در پی از همه‌گیری کرونا به وجود آمده بود، مجددا بهبود یافته و تقاضا برای محصولات مرتبط با هوش مصنوعی رونق گرفته است.</p><p style=\"margin-right:0px;\">سامسونگ که دفتر مرکزی آن در کره جنوبی مستقر است، بزرگترین سازنده تراشه‌های حافظه، گوشی‌های هوشمند و تلویزیون در جهان است.</p><p style=\"margin-right:0px;\">این شرکت قرار است در ۳۰ آوریل گزارش مالی دقیق خود را منتشر کند.</p><p style=\"margin-right:0px;\">این غول فناوری تخمین زده است که سود عملیاتی آن در سه ماهه ژانویه تا مارس امسال، به ۴.۹ میلیارد دلار برسد که ۹۳۱ درصد بیشتر از مدت مشابه در سال ۲۰۲۳ است.</p><p style=\"margin-right:0px;\">&nbsp;</p><p style=\"margin-right:0px;\">انتظار می‌رود که پس از رکود شدید طی یک سال گذشته، درآمد این شرکت با افزایش قیمت نیمه‌هادی‌ها یا همان نیم‌رساناها در بازار جهانی افزایش یابد.</p><p style=\"margin-right:0px;\">تخمین زده می‌شود که قیمت جهانی تراشه‌های حافظه، نسبت به سال گذشته حدود یک پنجم بالاتر رود.</p><p style=\"margin-right:0px;\">بخش نیمه هادی سامسونگ معمولا بزرگترین منبع درآمد این شرکت است.</p><p style=\"margin-right:0px;\">همچنین انتظار می‌رود که تقاضا برای نیمه‌هادی‌ها در سال جاری با رونق فناوری‌های هوش مصنوعی، همچنان بالا بماند.</p><p style=\"margin-right:0px;\">زمین لرزه‌ای که چند روز پیش تایوان را لرزاند، ممکن است عرضه جهانی تراشه‌ها را کاهش دهد و همین امر هم می‌تواند دست سامسونگ را برای بالاتر بردن قیمت‌ها باز کند.</p><p style=\"margin-right:0px;\">چندین تراشه ساز بزرگ جهان، از جمله شرکت تی‌اس‌ام‌سی در تایوان مستقر هستند و تراشه مورد نیاز شرکت‌های عظیم اپل و انویدیا را تامین می‌کنند.</p><p style=\"margin-right:0px;\">البته تی‌اس‌ام‌سی گفته است که زلزله تاثیر زیادی بر تولید این شرکت نداشته است، اما شاهد برخی اختلالات در پروسه تولید بوده است.</p><p style=\"margin-right:0px;\">همچنین انتظار می‌رود سود سامسونگ از فروش گوشی‌ معروف گلکسی اس۲۴ هم افزایش یابد، این گوشی جدید از ماه ژانویه به بازارها عرضه شده است.</p>",
                            ImageName = "news4.jpg",
                            IsActive = false,
                            ShortDescription = "شرکت سامسونگ الکترونیک می‌گوید انتظار دارد سود سه ماهه اول سال ۲۰۲۴ این شرکت نسبت به سال پیش از آن بیش از ۱۰ برابر شود.",
                            Title = "سامسونگ از رشد بیش از۹۰۰ درصدی سود خود خبر داد"
                        },
                        new
                        {
                            NewsId = 5,
                            CreateDate = new DateTime(2024, 5, 12, 13, 7, 2, 513, DateTimeKind.Local).AddTicks(3325),
                            CreatedBy = "0f8fad5b-d9cb-469f-a165-70867728950e",
                            Description = "<p style=\"margin-right:0px;\">آلفابت- مالک گوگل و همچنین متا (مالک فیسبوک و اینستاگرام) و اپل سه شرکتی هستند که به دلیل احتمال نقض قانون بازارهای دیجیتال مورد تحقیق قرار گرفته‌اند. این قانون در سال ۲۰۲۲ میلادی به اجرا درآمد.</p><p style=\"margin-right:0px;\">در صورت محرز شدن نقض این قانون، شرکت‌ها با جریمه‌هایی سنگین، تا سقف ۱۰ درصد درآمد سالانه، روبرو خواهند شد.</p><p style=\"margin-right:0px;\">این تحقیقات در حالی شروع شده است که سه هفته پیش اتحادیه اروپا شرکت اپل را یک میلیارد و ۸۰۰ میلیون یورو جریمه کرد؛ علت این اقدام نقض قوانین رقابتی در رابطه با پخش موسیقی بود.</p><p style=\"margin-right:0px;\">هفته پیش هم ایالات متحده با شکایت از شرکت اپل، این غول فن‌آوری را به انحصار بازار گوشی‌های هوشمند متهم کرد.</p><p style=\"margin-right:0px;\">اتحادیه اروپا می‌گوید ۵ مورد نقض احتمالی قانون بازارهای دیجیتال را بررسی می‌کند.</p><ul><li>مورد اول و دوم اینکه آیا اپل و آلفابت اجازه تماس و ارتباط آزاد بین اپلیکیشن‌ها و کاربران را می‌دهند؟</li><li>مورد سوم بررسی این موضوع است که آیا اپل حق انتخاب کافی در اختیار مشتریانش قرار می‌دهد یا نه.</li><li>مورد چهارم بررسی این اتهام در مورد متا است که این شرکت برای جلوگیری از مورد استفاده قرار گرفتن اطلاعات کاربران برای تبلیغات، بطور ناعادلانه آنها را ناچار به پرداخت پول می‌کند.</li><li>مورد پنجم هم مربوط به نحوه نمایش نتایج جستجوی گوگل است، اینکه آیا این شرکت نمایش محصولات و خدمات خود را در اولویت قرار می‌دهد یا خیر.</li></ul><p style=\"margin-right:0px;\">رئیس اقدامات ضدانحصار بازار در اتحادیه اروپا گفته است این تحقیقات حدود یک سال طول خواهد کشید.</p><p style=\"margin-right:0px;\">بگفته او بعید است که راه حل‌های پیشنهادی این سه شرکت به طور کامل با قوانین رقابت در بازار اتحادیه «تطابق داشته باشد.»</p><p style=\"margin-right:0px;\">هدف قوانین ضدانحصاری در بازار دیجیتال اتحادیه اروپا ایجاد فضای منصفانه‌تر از طریق محدود کردن نحوه عملکرد آنلاین شرکت‌های بزرگ است؛ از جمله اینکه به کاربران حق انتخاب بیشتری داده شود.</p>",
                            ImageName = "news5.jpg",
                            IsActive = false,
                            ShortDescription = "اتحادیه اروپا با متهم کردن چند غول‌ فن‌آوری در جهان به اقدامات غیر‌عادلانه‌ زیانبار برای کاربران و شرکت‌های رقیب، تحقیقاتی را در این مورد آغاز کرده است.",
                            Title = "اتحادیه اروپا تحقیقات از شرکت‌های اپل، متا و گوگل را آغاز کرد"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}