# MyReCapProject-Rent A Car
N-Katmanlı mimari yapısı ile hazırlanan, EntityFramework kullanılarak CRUD işlemlerinin yapıldığı, Wpf arayüzü ile çalışan, Araç Kiralama iş yerlerine yönelik örnek bir proje.
# LAYERS

## Entities Layer
Veritabanı nesneleri için oluşturulmuştur.

## Business Layer
Sunum katmanından gelen bilgileri gerekli koşullara göre işlemek veya denetlemek için oluşturulmuştur.

## Data Access Layer
Veritabanı CRUD işlemleri gerçekleştirmek için oluşturulmuştur.

## Core Layer
Core katmanının .Net Core ile hiçbir bağlantısı yoktur.Oluşturulan core katmanında ortak kodlar tutulur. Core katmanı ile, kurumsal bir yapıda, alt yapı ekibi ilgilenir.

# İndirilen paketler
### DataAccess
📦 Microsoft.EntityFrameworkCore.SqlServer
📦 Microsoft.EntityFrameworkCore
### Core
📦 Microsoft.EntityFrameworkCore.SqlServer
📦 Autofac (6.1.0)
📦 Autofac.Extensions.DependencyInjection
📦 Autofac.Extras.DynamicProxy
📦 FluentValidation
### Business
📦 Autofac
📦 Autofac.Extras.DynamicProxy
📦 FluentValidation
### WebAPI
📦 Autofac.Extensions.DependencyInjection
