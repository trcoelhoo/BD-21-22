SELECT title AS Titulos_Bookbeat FROM titles, sales, stores WHERE titles.title_id = sales.title_id AND sales.stor_id = stores.stor_id AND stor_name = 'Bookbeat'