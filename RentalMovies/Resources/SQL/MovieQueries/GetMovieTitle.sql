SELECT * FROM Movies WHERE id = (SELECT movieid FROM DVDs WHERE id = ?)
