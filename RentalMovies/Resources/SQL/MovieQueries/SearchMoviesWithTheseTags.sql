SELECT * FROM Movies 
WHERE 
title LIKE ?
AND releaseYear LIKE ?
AND country LIKE ?
AND
(
	('%[director]%' = ? OR id IN (SELECT movieid FROM MoviesTags WHERE tagId IN (SELECT id FROM Tags WHERE name LIKE '%[director]%' AND category = 'Writer')))
	AND ('%[genre]%' = ? OR id IN (SELECT movieid FROM MoviesTags WHERE tagId IN (SELECT id FROM Tags WHERE name LIKE '%[genre]%' AND category = 'Genre')))
	AND ('%[actor]%' = ? OR id IN (SELECT movieid FROM MoviesTags WHERE tagId IN (SELECT id FROM Tags WHERE name LIKE '%[actor]%' AND category = 'Actor')))
)