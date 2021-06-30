select i.* from ideaTeams i INNER JOIN idea_professor c on( c.idea_id_fk = i.id)   where c.professor_id_fk = 2 and c.accept_reject_idea='null'
            