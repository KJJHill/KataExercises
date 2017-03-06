-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
--    Rows: 30

select * from film f
join film_actor fa on f.film_id = fa.film_id
join actor a on a.actor_id = fa.actor_id
where a.first_name = 'Nick' and a.last_name = 'Stallone'


-- 2. All of the films that Rita Reynolds has appeared in
--    Rows: 20
select title from film f
join film_actor fa on fa.film_id = f.film_id
join actor a on a.actor_id = fa.actor_id
where a.first_name = 'Rita' and a.last_name = 'Reynolds'

-- 3. All of the films that Judy Dean or River Dean have appeared in
--    Rows: 46
select title from film f
join film_actor fa on fa.film_id = f.film_id
join actor a on a.actor_id = fa.actor_id
where a.first_name + a.last_name = 'JudyDean' or a.first_name + a.last_name = 'RiverDean'

-- 4. All of the the ‘Documentary’ films
--    Rows: 68
select title from film f
join film_category fc on f.film_id = fc.film_id
join category c on c.category_id = fc.category_id
where c.name = 'Documentary'

-- 5. All of the ‘Comedy’ films
--    Rows: 58
select title from film f
join film_category fc on f.film_id = fc.film_id
join category c on c.category_id = fc.category_id
where c.name = 'Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
--    Rows: 10 
select title from film f
join film_category fc on f.film_id = fc.film_id
join category c on c.category_id = fc.category_id
where c.name = 'Children' and f.rating = 'G'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
--    Rows: 3
select title from film f
join film_category fc on f.film_id = fc.film_id
join category c on c.category_id = fc.category_id
where c.name = 'Family' and f.rating = 'G' and f.length < 120

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
--    Rows: 9
select title from film f
join film_actor fa on fa.film_id = f.film_id
join actor a on a.actor_id = fa.actor_id
where a.first_name + a.last_name = 'MatthewLeigh' and f.rating = 'G'

-- 9. All of the ‘Sci-Fi’ films released in 2006
--    Rows: 61
select title from film f
join film_category fc on f.film_id = fc.film_id
join category c on c.category_id = fc.category_id
where c.name = 'Sci-Fi' and f.release_year = '2006'

-- 10. All of the ‘Action’ films starring Nick Stallone
--     Rows: 2
select title from film f
join film_actor fa on fa.film_id = f.film_id
join actor a on a.actor_id = fa.actor_id
join film_category fc on f.film_id = fc.film_id
join category c on c.category_id = fc.category_id
where a.first_name + a.last_name = 'NickStallone' and c.name = 'Action'

-- 11. The address of all stores, including street address, city, district, and country
--     Rows: 2
select a.address, c.city, a.district, co.country from address a
join store s on a.address_id = s.address_id
join city c on c.city_id = a.city_id
join country co on co.country_id = c.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
--     Rows: 2
select s.store_id, a.address, c.first_name, c.last_name from address a
join store s on a.address_id = s.address_id
join staff c on c.staff_id = s.manager_staff_id
order by s.store_id asc

-- 13. The first and last name of the top ten customers ranked by number of rentals 
--     Hint: #1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals
select top 10 c.first_name, c.last_name, count(r.rental_id) totalrentals from customer c
join rental r on r.customer_id = c.customer_id
group by c.last_name, c.first_name order by totalrentals desc


-- 14. The first and last name of the top ten customers ranked by dollars spent 
--     Hint: #1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent
select top 10 c.first_name, c.last_name, c.customer_id, sum(p.amount) totalpayment from customer c
join payment p on p.customer_id = c.customer_id
group by c.last_name, c.first_name, c.customer_id order by totalpayment desc


--*****Need to ask for help on this one
-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments),
-- and average sale of each store 
--     Hint: Store 1 has 7928 total rentals and Store 2 has 8121 total rentals
select s.store_id, a.address, 
sum(p.amount) as sales, AVG(p.amount) as average, count(r.rental_id) as rentals from address a
join store s on a.address_id = s.address_id
join rental r on r.staff_id = s.manager_staff_id 
join payment p on s.manager_staff_id = p.staff_id
group by s.store_id, a.address order by rentals

select count(*) from rental group by staff_id 
select * from store

select s.store_id, a.address, count(r.rental_id) as rentals from address a
join store s on a.address_id = s.address_id
join rental r on r.staff_id = s.manager_staff_id 
group by s.store_id, a.address order by rentals

--adding the join of payment somehow throws off my count which was wrong to begin with anyway
select s.store_id, a.address, count(r.rental_id) as rentals from address a
join store s on a.address_id = s.address_id
join rental r on r.staff_id = s.manager_staff_id 
join payment p on s.manager_staff_id = p.staff_id
group by s.store_id, a.address order by rentals



-- 16. The top ten film titles by number of rentals 
--     Hint: #1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals
select top 10 f.title, count(r.rental_id) as rentals from film f
join inventory i on f.film_id = i.film_id
join rental r on i.inventory_id = r.inventory_id
group by f.title order by rentals desc

-- 17. The top five film categories by number of rentals 
--     Hint: #1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals
select top 10 c.name, count(r.rental_id) as rentals from film f
join inventory i on f.film_id = i.film_id
join rental r on i.inventory_id = r.inventory_id
join film_category fc on f.film_id = fc.film_id
join category c on c.category_id = fc.category_id 
group by c.name order by rentals desc

-- 18. The top five Action film titles by number of rentals 
--     Hint: #1 should have 30 rentals and #5 should have 28 rentals
select top 10 f.title, count(r.rental_id) as rentals from film f
join inventory i on f.film_id = i.film_id
join rental r on i.inventory_id = r.inventory_id
join film_category fc on f.film_id = fc.film_id
join category c on c.category_id = fc.category_id 
where c.name = 'Action' group by f.title order by rentals desc

--*****Need to ask for help on this one - I get Susan Davis as the first one with 825
-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
--     Hint: #1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals
select top 11 a.first_name, a.last_name, count(r.rental_id) as rentals from film f
join inventory i on f.film_id = i.film_id
join rental r on i.inventory_id = r.inventory_id
join film_actor fa on f.film_id = fa.film_id
join actor a on fa.actor_id = a.actor_id 
group by a.first_name, a.last_name order by rentals desc

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
--     Hint: #1 should have 87 rentals and #5 should have 72 rentals
select top 10 a.first_name, a.last_name, count(r.rental_id) as rentals from film f
join inventory i on f.film_id = i.film_id
join rental r on i.inventory_id = r.inventory_id
join film_actor fa on f.film_id = fa.film_id
join actor a on fa.actor_id = a.actor_id 
join film_category fc on f.film_id = fc.film_id
join category c on c.category_id = fc.category_id 
where c.name = 'Comedy' group by a.first_name, a.last_name order by rentals desc
