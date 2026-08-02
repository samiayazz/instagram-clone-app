package dev.igclone.api.model.entity.common;

import jakarta.persistence.MappedSuperclass;

import java.time.LocalDateTime;

@MappedSuperclass
public abstract class UpdatableEntity extends BaseEntity {
    private LocalDateTime dateOfUpdate;

    public LocalDateTime getDateOfUpdate() {
        return dateOfUpdate;
    }

    public void setDateOfUpdate(LocalDateTime dateOfUpdate) {
        this.dateOfUpdate = dateOfUpdate;
    }
}
