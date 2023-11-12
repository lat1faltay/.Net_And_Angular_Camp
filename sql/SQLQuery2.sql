-- select

-- select ContactName Adi, CompanyName Sirket_Adi, City Sehir from Customers

-- Select * from Customers where City = 'Berlin'

-- Case insensitive Yani sql büyük küçük harf duyarsız

-- select * from Products where CategoryID=1 or CategoryID=3

-- select * from Products where CategoryID=1 and UnitPrice>=10

-- order by verilen kayıtları artan ya da azalan sıraya göre listelememize yarar
-- select * from Products order by UnitPrice

-- asc = ascending Yani artan sıraya göre listeliyor
-- select * from Products order by UnitPrice asc
-- desc = descending yani düşen asnlında azalan sıraya göre listeleniyor
-- select * from Products where CategoryID=1 order by UnitPrice desc

-- Products'ta kaç satır var sayısını veriyor (Tek bir kolon ve tek bir satır gelmesi gerekiyor çünkü bu alanda sadece saye veriyor sana)
-- select count(*) from Products

-- Hangi kategoride kaç farklı ürün var dediğimizde
-- select count(*) from Products where CategoryID=2

-- bütün kategorilere bak ve bulduğun kategorileri bana tekrar etmeyecek şekilde listele
--select CategoryID from Products group by CategoryID

-- hangi kategoride kaç ürün var için çalışması gereken kod
-- select CategoryID,count(*) from Products group by CategoryID

-- yukarıdaki kod ile hangi kategoride kaç farklı ürün olduğunu bulduk
-- having ile de örneğin bu kategorilerde içinde 10 tane kayıttan daha az ya da fazla olan kayıtları getir demek için kullanılır
-- select CategoryID,count(*) from Products group by CategoryID having count(*)< 10


-- öncelikle where komutu ile verimi filtrele sonrasında group by ile verileri grupla sonrasında da having ile sayısı 10'dan az olanları listele demiş olduk
-- select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)< 10

-- inner join hem products'taki kayıtları hemde categories'deki kayıtları bir araya getiriyor 
-- on ise şart koşuyor products'ın categoryId'leri categories'deki categoriID'lere eşit ise bu sorgu çalışır gibi düşünebiliriz
-- select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID


-- from * yerine sadece istediğimiz kolonları çağırdık fakat burada istediğimiz kolonları çağırırken hangi tablonun hangi kolonunun olduğunu yazmak gerekiyor
-- 2 farklı tablodan veri çekeceğimiz için sadece sütun adını yazarak sütundaki verilere erişemeyiz
-- select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
-- from Products inner join Categories on Products.CategoryID = Categories.CategoryID

-- NOTTT inner join iki tabloda da eşleşen data varsa sadece onu getirir eğer ki tablolarda veriler eşleşmeyen data varsa onu getirmez 

-- DTO Data Transformatiob Object

-- eğer tablo isminde ya da kolon isminde boşluk varsa köşeli parantezler ile yazılır
-- inner join sadece ortak kolonları getirirken left join ortak olmayan kolonları da getiriyor
-- hatta left join yani solda olup sağda olmayan verileri de getir demek olduğundan ismi ordan geliyor

--select * from Products p left join [Order Details] od
--on p.ProductID = od.ProductID

-- farklı bir örnek
-- aşağıdaki sorgunun anlamı
-- sistemde müşteri olupta hiç sipariş vermeyen yani siparişi boşsa aslında sipariş sayısı null ise (is null ile kontrolü sağlanıyor) bana getir demek 
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

-- NOTTT inner join ve left join özelliklerini kullanmak için ortak bir kolon olmak zorunda yoksa kullanamayız

-- NOT left join gibi bir join daha var o da right join left'in tam tersi genelde left join kullanılıyor
