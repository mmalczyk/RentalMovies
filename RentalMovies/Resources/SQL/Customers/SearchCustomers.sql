SELECT * FROM Customers
WHERE name
	LIKE ? AND surname LIKE ?
	AND pesel LIKE ?
	AND phone LIKE ?
	AND address LIKE ?