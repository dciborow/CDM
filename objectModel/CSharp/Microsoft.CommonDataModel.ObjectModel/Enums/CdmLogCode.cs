﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.CommonDataModel.ObjectModel.Enums
{
    public enum CdmLogCode
    {
        None,
        ErrAdapterNotFound,
        ErrDocAdapterNotFound,
        ErrDocEntityDocSavingFailure,
        ErrDocEntityReplacementFailure,
        ErrDocImportSavingFailure,
        ErrDocIsNotFolder,
        ErrDocPartitionSchemaSavingFailure,
        ErrDocSubManifestSavingFailure,
        ErrDocSymbolNotFound,
        ErrDocWrtDocNotfound,
        ErrEntityCreationFailed,
        ErrIndexFailed,
        ErrInvalidPath,
        ErrObjectWithoutOwnerFound,
        ErrPartitionFileModTimeFailure,
        ErrPathIsDuplicate,
        ErrPathNullObjectPath,
        ErrPersistAdapterNotFoundForNamespace,
        ErrPersistAdapterWriteFailure,
        ErrPersistCardinalityPropMissing,
        ErrPersistCdmEntityFetchError,
        ErrPersistClassMissing,
        ErrPersistConversionError,
        ErrPersistCsvProcessingError,
        ErrPersistDeserializeError,
        ErrPersistDocConversionFailure,
        ErrPersistDocFetchError,
        ErrPersistDocNameLoadFailure,
        ErrPersistEntityPathNotFound,
        ErrPersistEntityAttrUnsupported,
        ErrPersistEntityDeclarationMissing,
        ErrPersistEntityParsingError,
        ErrPersistFailure,
        ErrPersistFilePersistError,
        ErrPersistFilePersistFailed,
        ErrPersistFileReadFailure,
        ErrPersistSaveLinkedDocs,
        ErrPersistFileWriteFailure,
        ErrPersistInvalidEntityPath,
        ErrPersistInvalidExtensionTrait,
        ErrPersistJsonAttrContextConversionError,
        ErrPersistJsonDatatypeConversionError,
        ErrPersistJsonDatatypeRefConversionError,
        ErrPersistJsonImportConversionError,
        ErrPersistJsonObjectRefConversionError,
        ErrPersistManifestSavingFailure,
        ErrPersistModelIdDuplication,
        ErrPersistModelIdNotFound,
        ErrPersistModelJsonAttrConversionFailure,
        ErrPersistModelJsonEntityConversionError,
        ErrPersistModelJsonEntityDeclarationConversionError,
        ErrPersistModelJsonEntityDeclarationConversionFailure,
        ErrPersistModelJsonEntityPartitionConversionError,
        ErrPersistModelJsonRelConversionError,
        ErrPersistNullDocName,
        ErrPersistObjectNotFound,
        ErrPersistProjInvalidOpsType,
        ErrPersistProjInvalidType,
        ErrPersistProjUnsupportedProp,
        ErrPersistUnsupportedJsonSemVer,
        ErrPersistInvalidMaxCardinality,
        ErrPersistInvalidMinCardinality,
        ErrProjFailedToResolve,
        ErrProjRefAttrStateFailure,
        ErrProjInvalidAttrState,
        ErrProjRenameFormatIsNotSet,
        ErrProjSourceError,
        ErrProjStringError,
        ErrProjUnsupportedAttrGroups,
        ErrRelMaxResolvedAttrReached,
        ErrResolutionFailure,
        ErrResolveEntityFailure,
        ErrResolveEntityNotFound,
        ErrResolveEntityRefError,
        ErrResolveFolderNotFound,
        ErrResolveManifestFailed,
        ErrResolveReferenceFailure,
        ErrStorageAdapterNotFound,
        ErrStorageInvalidAdapterPath,
        ErrStorageInvalidPathFormat,
        ErrStorageMissingJsonConfig,
        ErrStorageMissingNamespace,
        ErrStorageMissingTypeJsonConfig,
        ErrStorageNamespaceMismatch,
        ErrStorageNamespaceNotRegistered,
        ErrStorageNullAdapter,
        ErrStorageNullAdapterConfig,
        ErrStorageNullCorpusPath,
        ErrStorageNullNamespace,
        ErrStorageObjectNodeCastFailed,
        ErrSymbolNotFound,
        ErrTraitArgumentMissing,
        ErrTraitAttrFetchError,
        ErrTraitResolutionFailure,
        ErrUnexpectedDataType,
        ErrUnexpectedType,
        ErrUnrecognizedDataType,
        ErrUnsupportedRef,
        ErrUnsupportedType,
        ErrValdnIntegrityCheckFailure,
        ErrValdnInvalidCorpusPath,
        ErrValdnInvalidDoc,
        ErrValdnInvalidMaxCardinality,
        ErrValdnInvalidMinCardinality,
        ErrValdnInvalidResx,
        ErrValdnMissingDoc,
        ErrValdnMissingLanguageTag,
        ErrUnrecognizedType,
        WarnPartitionGlobAndRegexPresent,
        WarnDocChangesDiscarded,
        WarnDocImportNotLoaded,
        WarnPartitionFileFetchFailed,
        WarnIdentifierArgumentsNotSupported,
        WarnPartitionInvalidArguments,
        WarnPersistCustomExtNotSupported,
        WarnPersistPartitionLocMissing,
        WarnPersistFileModTimeFailure,
        WarnPersistFileReadFailure,
        WarnPersistJsonSemVerInvalidFormat,
        WarnPersistJsonSemVerMandatory,
        WarnPersistModelJsonRelReadFailed,
        WarnPersistRelUndefinedSourceEntity,
        WarnPersistRelUndefinedTargetEntity,
        WarnPersistUnsupportedJsonSemVer,
        WarnPersistEntityMissing,
        WarnPersistEnumNotFound,
        WarnPersistPartitionNameNull,
        WarnProjCreateForeignKeyTraits,
        WarnProjFKWithoutSourceEntity,
        WarnProjRemoveOpsFailed,
        WarnProjRenameAttrNotSupported,
        WarnResolveAttrFailed,
        WarnResolveEntityFailed,
        WarnResolveImportFailed,
        WarnResolveObjectFailed,
        WarnResolveReferenceFailure,
        WarnStorageExpectedPathPrefix,
        WarnStorageRemoveAdapterFailed,
        WarnAnnotationTypeNotSupported,
        WarnValdnEntityNotDefined,
        WarnValdnMaxOrdinalTooHigh,
        WarnValdnPrimaryKeyMissing,
        WarnValdnOrdinalStartEndOrder
    }
}
