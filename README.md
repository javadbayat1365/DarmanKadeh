<div dir="rtl">
لازم به ذکر است این پروژه تستی برای شرکت درمانکده طراحی شده است.بدلیل زمان کم تا جایی که زمان اجازه داد خودم کد زدم و همچنین از کد های آماده قبلی و کتاب خانه های آماده استفاده شد.
در مواردی کار نیمه کار ماند. مانند موارد زیر:
1- بردن کدها از کنترولرها به لایه سرویس
2- بررسی وابستگی های انتیتی قبل از حذف آن
...

</div>
<div dir="ltr">

#


## Testing it out
1. Clone or download this repository
2. Build the solution using command line with `dotnet build`
3. Go to **DarmanKadeh** directory and run project using command line with `dotnet run`

## Techniques and Features
- JWT Authentication
- Secure JWT using Encryption (JWE)
- Exception Handling using Custom Middleware
- Automatic Validation
- Standard API Resulting
- Dependency Injection using [Autofac (Ioc Container)](https://github.com/autofac/Autofac)
- Map resources using [AutoMapper](https://github.com/AutoMapper/AutoMapper)
- Async/Await Best Practices
- Using [Swagger](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) (Swashbuckle)
- Auto Document Generator for Swagger
- Integrate Swagger and JWT/OAuth Authentication
- Best Practices for Performance and Security

</div>

---

<div dir="rtl">


## تکنولوژی، ابزار ها و قابلیت ها
  - **لایه بندی اصولی پروژه (Project Layering and Architecture)** : در این پرژه تستی برای شرکت درمانکده لایه بندی اصولی یک پروژه انجام شده. همچنین مباحث Repository.
  - **احراز هویت (Authentication)**
    - **ASP.NET Core Identity** : احراز هویت توسط Identity 
    - **(Json Web Token) JWT** : احراز هویت توسط Jwt
    - **(Json Web Encryption) JWE** : ایمن سازی توکن ها بوسیله [رمزنگاری توکن (JWE)] 
    - **Custom Middleware** : نوشتن یک میدلویر سفارشی جهت لاگ تمامی خطا (Exception) ها
    - **Custom Exception** : نوشتن Exception برای مدیریت ساده تر خطا ها
  - **تزریق وابستگی (Dependency Injection**)
    - **ASP.NET Core IOC Container** : استفاده از Ioc container داخلی Asp Core
    - **Autofac** : استفاده از محبوب ترین کتابخانه [Autofac (Ioc Container)]
  - **ارتباط با دیتابیس (Data Access)**
    - **Entity Framework Core** : استفاده از EF Core
    - **Auto Entity Registration** : ثبت Entity های DbContext به صورت خودکار توسط Reflection
    - **Automatic Configuration** : اعمال کانفیگ های EntityTypeConfiguration (FluentApi) به صورت خودکار توسط Reflection
    - **Sequential Guid** : بهینه سازی مقدار دهی identity برای Guid به صورت خودکار توسط Reflection
    - **Data Intitializer** : یک معماری اصولی برای Seed کردن مقادیر اولیه به Database
  - **ابزار (Swashbuckle) Swagger**
    - **Swagger UI** : ساخت یک ظاهر شکیل به همراه داکیومنت Aciton ها و Controller های پروژه و امکان تست API ها توسط [Swagger](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) UI
    - **Auto Summary Document Generation** : تولید خودکار داکیومنت (توضیحات) برای API های پروژه
  - **دیگر قابلیت ها**
    - **API Standard Resulting** : استاندارد سازی و یک دست سازی خروجی API ها توسط ActionFilter
    - **Automatic Model Validation** : اعتبار سنجی خودکار
    - **AutoMapper** : جهت Mapping اشیاء توسط کتابخانه محبوب [AutoMapper](https://github.com/AutoMapper/AutoMapper) 
    - **Auto Mapping** :  سفارشی سازی وایجاد [یک معماری حرفه ای](https://github.com/mjebrahimi/auto-mapping) برای Mapping اشیا توسط Reflection
    - **Site Setting** : مدیریت تنظیمات پروژ توسط Configuration و ISnapshotOptions
    - **Minimal Mvc** : حذف سرویس های اضافه MVC برای افزایش پرفرمنس در API نویسی
    - **Best Practices** : اعمال Best Practices ها جهت بهینه سازی، افزایش پرفرمنس و کدنویسی تمیز و اصولی

</div>
<div dir="rtl">
قطعا آینده بهتری خواهیم داشت :)
</div>