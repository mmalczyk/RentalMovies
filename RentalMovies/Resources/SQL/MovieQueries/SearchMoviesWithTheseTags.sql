SELECT * FROM Movies 
WHERE 
title LIKE ?
AND releaseYear LIKE ?
AND country LIKE ?
AND
(
	('%[director]%' = ? OR moviesId IN (SELECT movieid FROM MoviesTags WHERE tagId IN (SELECT tagId FROM Tags WHERE name LIKE '%[director]%' AND category = 'Writer')))
	AND ('%[genre]%' = ? OR moviesId IN (SELECT movieid FROM MoviesTags WHERE tagId IN (SELECT tagId FROM Tags WHERE name LIKE '%[genre]%' AND category = 'Genre')))
	AND ('%[actor]%' = ? OR moviesId IN (SELECT movieid FROM MoviesTags WHERE tagId IN (SELECT tagId FROM Tags WHERE name LIKE '%[actor]%' AND category = 'Actor')))
)