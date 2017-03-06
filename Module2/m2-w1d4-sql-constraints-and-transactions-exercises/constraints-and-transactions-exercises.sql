-- Write queries to return the following:
-- The following changes are applied to the "pagila" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
insert into [dbo].[actor] ([first_name], [last_name]) values ('Hamilton', 'Avenue')
update actor set first_name = 'Hampton' where first_name + last_name = 'HamiltonAvenue'
insert into actor (first_name, last_name) values ('Lisa','Byway')

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in 
-- ancient Greece", to the film table. The movie was released in 2008 in English. 
-- Since its an epic, the run length is 3hrs and 18mins. There are no special 
-- features, the film speaks for itself, and doesn't need any gimmicks.	
insert into film ([title], [description], [release_year], [length], language_id)
values ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in 
-- ancient Greece','2008', '198', '1')

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly 
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
select film_id from film where title = 'Euclidean PI' --1001
select actor_id from actor where first_name = 'Hampton' --201
select actor_id from actor where first_name + last_name = 'LisaByway' --202

insert into film_actor (film_id, actor_id) values ('1001', '202')
insert into film_actor (film_id, actor_id) values ('1001', '201')

--*** Want to ask John about whether this one could be executed using a join statement
--insert into film_actor (film_id, actor_id) 
-- (select f.film_id, a.actor_id from film f 
-- join film_actor fa on f.film_id = fa.film_id
-- join actor a on fa.actor_id = a.actor_id
-- where f.title = 'Euclidean PI' and a.first_name+a.last_name = 'HamptonAvenue')


-- 4. Add Mathmagical to the category table.
insert into category (name) values ('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI", 
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
select category_id from category where name = 'Mathmagical' --17

select f.film_id from film f where title in ('Euclidean PI', 'Egg Igby', 'Karate Moon', 'Random Go', 'Young Language')
--274, 494, 714, 996, 1001

insert into film_category (film_id, category_id) values ('274', '17')
insert into film_category (film_id, category_id) values ('494', '17')
insert into film_category (film_id, category_id) values ('714', '17')
insert into film_category (film_id, category_id) values ('996', '17')
insert into film_category (film_id, category_id) values ('1001', '17')


-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films 
-- accordingly.
-- (5 rows affected)

update f set rating = 'G' from film f 
join film_category fc on f.film_id = fc.film_id
join category c on fc.category_id = c.category_id  
where c.name = 'Mathmagical'


-- 7. Add a copy of "Euclidean PI" to all the stores.
select * from inventory 
select store_id from inventory group by store_id

insert into inventory 
 (film_id, store_id) 
 select film_id, 1 from film where title = 'Euclidean PI'

insert into inventory (film_id, store_id) 
 select film_id, 2 from film where title = 'Euclidean PI'

select * from inventory

-- 8. The Feds have stepped in and have impounded all copies of the pirated film, 
-- "Euclidean PI". The film has been seized from all stores, and needs to be 
-- deleted from the film table. Delete "Euclidean PI" from the film table. 
-- (Did it succeed? Why?)

delete
from film where title = 'Euclidean PI'

-- No it did not work because the film id is used as a foreign key in the film actor database

-- 9. Delete Mathmagical from the category table. 
-- (Did it succeed? Why?)
delete 
from category where name = 'Mathmagical'
-- No because the category id is being referenced in the film_cateogory table

--**** Need to ask John about this one why the delete doesn't allow me to join the tables
-- 10. Delete all links to Mathmagical in the film_category tale. 
-- (Did it succeed? Why?)

select *
--delete
from film_category as fc
inner join category c on fc.category_id = c.category_id
where c.name = 'Mathmagical'

delete 
from film_category where category_id = '17'

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI". 
-- (Did either deletes succeed? Why?)

--Deleting Mathmagical worked because it was no longer being referenced in the film category table.
--Deleting Euclidean PI would not work because it is still be used in the film actor table.


-- 12. Check database metadata to determine all constraints of the film id, and 
-- describe any remaining adjustments needed before the film "Euclidean PI" can 
-- be removed from the film table.

--you should be able to delete the data that reference 'Euclidean PI' out of the film actor table 
-- and then out of the inventory table and that should clear up where the film_id is being referenced
--after that you should be able to delete Euclidean PI out of the film table.
-- I would also double check one last time that there are no references to the 'Euclidean PI' film id in the 
--film category table also.
