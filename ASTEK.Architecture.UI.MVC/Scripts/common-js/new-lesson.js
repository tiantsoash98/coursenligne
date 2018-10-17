function loadCKEditor(index) {
    CKEDITOR.replace('content-lesson');

    for (var i = 1; i < index; i++) {
        CKEDITOR.replace("content-part-" + i);
    }
}

function addPart(number){
	jQuery('<div/>', { 
        "id": 'part' + number,
		"class": "lesson-part"
    }).appendTo('#chapter-parts');
	
	jQuery('<hr/>', {}).appendTo('#part' + number);
	
	jQuery('<h5/>', {
		"class": "pre-title",
		"text": "Partie " + number
	}).appendTo('#part' + number);
	
	addFormGroup(number, "Title", "Titre", 3);
	addFormGroup(number, "Content", "Contenu", 10);

    CKEDITOR.replace("content-part-" + number);
}

function addFormGroup(number, type, wording, rows) {
    var typeLower = type.toLowerCase();

	jQuery('<div/>', {
		"id": "form-group-" + typeLower + "-" + number,
		"class": "form-group small-space-top"
	}).appendTo('#part' + number);
	
	jQuery('<label/>', {
		"class": "col-md-12 form-group",
		"for": typeLower + "-part-" + number,
		"text": wording
	}).appendTo('#form-group-' + typeLower + "-" + number);
	
	jQuery('<div/>', {
		"id": "row-" + typeLower + "-" + number,
		"class": "col-md-12"
    }).appendTo('#form-group-' + typeLower + "-" + number);
	
    jQuery('<textarea/>', {
        "name": "PartsInput[" + (number - 1) + "]." + type,
		"class": "form-control col-md-12",
		"rows": rows,
		"id": typeLower + "-part-" + number,
	}).appendTo('#row-' + typeLower + "-" + number);
}

function removePart(id) {
    $(id).remove();
}