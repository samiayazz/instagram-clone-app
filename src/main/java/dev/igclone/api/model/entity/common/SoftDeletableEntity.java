package dev.igclone.api.model.entity.common;

import jakarta.persistence.MappedSuperclass;

import java.time.LocalDateTime;

@MappedSuperclass
public abstract class SoftDeletableEntity extends UpdatableEntity {
    private LocalDateTime dateOfDeletion;

    public LocalDateTime getDateOfDeletion() {
        return dateOfDeletion;
    }

    public void setDateOfDeletion(LocalDateTime dateOfDeletion) {
        this.dateOfDeletion = dateOfDeletion;
    }
}
