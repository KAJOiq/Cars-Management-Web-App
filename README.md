
# Cars Management Web App

تطبيق **Cars Management Web App** هو نظام لإدارة بيانات السيارات باستخدام **ASP.NET Core MVC** و**Entity Framework Core** و**SQLite**. يوفر التطبيق واجهة سهلة الاستخدام تمكنك من تنفيذ عمليات **CRUD** (إضافة، قراءة، تعديل، حذف) على بيانات السيارات بواجهة استخدام بسيطة وتفاعلية.

---

## 🚀 الميزات

- **إضافة سيارات جديدة**: إمكانية إضافة سيارة جديدة مع تفاصيل مثل النوع والموديل.
- **عرض قائمة السيارات**: عرض قائمة شاملة بجميع السيارات المسجلة.
- **تحديث بيانات السيارات**: تعديل البيانات المتوفرة لأي سيارة.
- **حذف سيارة**: إزالة سيارة من قاعدة البيانات.
- **التحقق من صحة البيانات**: ضمان صحة البيانات المدخلة مثل التأكد من إدخال موديل السيارة كأربعة أرقام (مثل 2023).

---

## 🛠️ التقنيات المستخدمة

- **ASP.NET Core 8**: لبناء جانب الخادم (الخلفية).
- **Entity Framework Core**: لإدارة بيانات قاعدة البيانات باستخدام ORM.
- **SQLite**: قاعدة بيانات خفيفة وسهلة التكوين.
- **Bootstrap**: تصميم واجهات استجابة مع الأجهزة المختلفة.

---

## ⚙️ الإعداد

للبدء باستخدام المشروع، اتبع الخطوات التالية:

1. **نسخ المشروع**:
   ```bash
   git clone https://github.com/KAJOiq/Cars-Management-Web-App.git
الانتقال إلى مجلد المشروع:

cd Cars-Management-Web-App
تثبيت التبعيات:


dotnet restore
تحديث قاعدة البيانات:

dotnet ef database update
 ## تشغيل التطبيق: 


dotnet run
 ##  فتح التطبيق: بعد التشغيل، يمكنك الوصول إلى التطبيق عبر الرابط http://localhost:5000.

 ##  📖 كيفية الاستخدام 
إضافة سيارة: انتقل إلى صفحة إضافة سيارة، وقم بتعبئة الحقول المطلوبة، ثم انقر على حفظ.
عرض جميع السيارات: انتقل إلى صفحة قائمة السيارات لمشاهدة كافة السيارات المسجلة.
تعديل أو حذف: استخدم أزرار تعديل وحذف الموجودة بجانب كل سيارة لتحديث أو إزالة السيارة من القائمة.
🗂️ هيكل المشروع
يتم تنظيم المشروع على النحو التالي:

Controllers/: يحتوي على ملفات تحكم الطلبات (CRUD).
Models/: يحتوي على الكائنات الممثلة لجداول قاعدة البيانات.
Views/: يحتوي على ملفات الواجهة (Razor Views) لكل صفحة.
Data/: إعدادات تكوين وإدارة قاعدة البيانات.