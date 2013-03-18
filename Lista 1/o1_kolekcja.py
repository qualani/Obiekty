def typ_kolekcja(torba):
	if torba:
		return []
	else:
		return set()

def wstaw(L,e):
	if type(L) == set:
		L.add(e)
	else:
		L.append(e)
def szukaj(L,e):
	if type(L) == set:
		if e in L: return 1
	else:
		return L.count(e)
L = typ_kolekcja(True)
wstaw(L,1)
wstaw(L,2)
wstaw(L,1)
print L
print szukaj(L,1)
print szukaj(L,2)
