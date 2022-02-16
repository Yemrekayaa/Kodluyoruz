# SQL Ödev8

### test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.

> CREATE TABLE employee(id SERIAL PRIMARY KEY, name VARCHAR(50) NOT NULL, birthday DATE NOT NULL, email VARCHAR(100) NOT NULL)

---

### Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.

> [employee](https://github.com/Yemrekayaa/Kodluyoruz/tree/main/SQL/sql-8/employee.sql)

---

### Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.

> UPDATE employee SET name='John' WHERE id=1
> UPDATE employee SET name='Maria', birthday='1987-12-24', email='maria@maria.com' WHERE id=1 
> UPDATE employee SET name='Derek' WHERE name LIKE 'A%a' 
> UPDATE employee SET name='Josh' WHERE id>47
> UPDATE employee SET birthday='1901-01-01' WHERE birthday<'1940-01-01'

---

### Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

> DELETE FROM employee WHERE id=3 
> DELETE FROM employee WHERE id BETWEEN 10 AND 15 
> DELETE FROM employee WHERE birthday<'1950-01-01' 
> DELETE FROM employee WHERE name LIKE 'A%' 
> DELETE FROM employee WHERE id%2=1 