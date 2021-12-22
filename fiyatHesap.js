function hesapla(h_id) {
    var gun = document.getElementById('gun_' + h_id);
    var sonuc = document.getElementById('sonuc_' + h_id);
    var fiyat = document.getElementById('fiyat_' + h_id);
    sonuc.value = gun.value * fiyat.value;
    
    if (gun.value <= 7) {
       
       bootbox.alert('sonuc=' + sonuc.value + 'TL');
            
    }
    else {
        bootbox.alert('7 günden fazla araç kiralayamazsınız.')
    }
    
}
