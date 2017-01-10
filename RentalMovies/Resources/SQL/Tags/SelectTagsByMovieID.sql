SELECT * from Tags
WHERE id IN
(
	SELECT tagId
	FROM MoviesTags
	WHERE movieId = ?)
AND category = ?