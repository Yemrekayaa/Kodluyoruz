# Insertion Sort 

> [22, 27, 16, 2, 18, 6] -> Insertion Sort

## Yukarı verilen dizinin sort türüne göre aşamalarını yazınız

> **[22**, 27, 16, 2, 18 ,6]

> **[22, 27**, 16, 2, 18 ,6]

> **[16, 22, 27**, 2, 18, 6]

> **[2, 16, 22, 27**, 18, 6]

> **[2, 16, 18, 22, 27**, 6]

> **[2, 6, 16, 18, 22, 27]**

---

## Big-O gösterimini yazınız

> O(n^2)

---

## Time Complexity

> Average Case: Dizi tam ters olsaydı en kötüsü olacaktı. Eğer sıralı olsaydı, sadece hepsini bir defa kontrol edecekti ve en iyisi olacaktı. İkisi de olmadığı için Avarage Case.

---

## Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız

> Average Case

---

## [7, 3, 5, 8, 2, 9, 4, 15, 6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

> **[7**, 3, 5, 8, 2, 9, 4, 15, 6] Başlangıç

> **[3, 7**, 5, 8, 2, 9, 4, 15, 6] 1. Adım

> **[3, 5, 7**, 8, 2, 9, 4, 15, 6] 2. Adım

> **[3, 5, 7, 8**, 2, 9, 4, 15, 6] 3. Adım

> **[2, 3, 5, 7, 8**, 9, 4, 15, 6] 4. Adım