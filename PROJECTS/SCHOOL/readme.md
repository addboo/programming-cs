# School Project

## Βάση Δεδομένων

1. Δημιουργία Βάσης Δεδομένων με όνομα **School**

2. Δημιουργία Πίνακα **students**:

```sql
CREATE TABLE `students` (
  `id` int UNSIGNED NOT NULL,
  `firstname` varchar(40) NOT NULL,
  `lastname` varchar(40) NOT NULL,
  `tel` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

ALTER TABLE `students`
  ADD PRIMARY KEY (`id`);
  
ALTER TABLE `students`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;
```
