using System;

namespace ns0
{
	// Token: 0x0200003E RID: 62
	internal enum Enum15 : uint
	{
		// Token: 0x04000122 RID: 290
		Success,
		// Token: 0x04000123 RID: 291
		Wait0 = 0U,
		// Token: 0x04000124 RID: 292
		Wait1,
		// Token: 0x04000125 RID: 293
		Wait2,
		// Token: 0x04000126 RID: 294
		Wait3,
		// Token: 0x04000127 RID: 295
		Wait63 = 63U,
		// Token: 0x04000128 RID: 296
		Abandoned = 128U,
		// Token: 0x04000129 RID: 297
		AbandonedWait0 = 128U,
		// Token: 0x0400012A RID: 298
		AbandonedWait1,
		// Token: 0x0400012B RID: 299
		AbandonedWait2,
		// Token: 0x0400012C RID: 300
		AbandonedWait3,
		// Token: 0x0400012D RID: 301
		AbandonedWait63 = 191U,
		// Token: 0x0400012E RID: 302
		UserApc,
		// Token: 0x0400012F RID: 303
		KernelApc = 256U,
		// Token: 0x04000130 RID: 304
		Alerted,
		// Token: 0x04000131 RID: 305
		Timeout,
		// Token: 0x04000132 RID: 306
		Pending,
		// Token: 0x04000133 RID: 307
		Reparse,
		// Token: 0x04000134 RID: 308
		MoreEntries,
		// Token: 0x04000135 RID: 309
		NotAllAssigned,
		// Token: 0x04000136 RID: 310
		SomeNotMapped,
		// Token: 0x04000137 RID: 311
		OpLockBreakInProgress,
		// Token: 0x04000138 RID: 312
		VolumeMounted,
		// Token: 0x04000139 RID: 313
		RxActCommitted,
		// Token: 0x0400013A RID: 314
		NotifyCleanup,
		// Token: 0x0400013B RID: 315
		NotifyEnumDir,
		// Token: 0x0400013C RID: 316
		NoQuotasForAccount,
		// Token: 0x0400013D RID: 317
		PrimaryTransportConnectFailed,
		// Token: 0x0400013E RID: 318
		PageFaultTransition = 272U,
		// Token: 0x0400013F RID: 319
		PageFaultDemandZero,
		// Token: 0x04000140 RID: 320
		PageFaultCopyOnWrite,
		// Token: 0x04000141 RID: 321
		PageFaultGuardPage,
		// Token: 0x04000142 RID: 322
		PageFaultPagingFile,
		// Token: 0x04000143 RID: 323
		CrashDump = 278U,
		// Token: 0x04000144 RID: 324
		ReparseObject = 280U,
		// Token: 0x04000145 RID: 325
		NothingToTerminate = 290U,
		// Token: 0x04000146 RID: 326
		ProcessNotInJob,
		// Token: 0x04000147 RID: 327
		ProcessInJob,
		// Token: 0x04000148 RID: 328
		ProcessCloned = 297U,
		// Token: 0x04000149 RID: 329
		FileLockedWithOnlyReaders,
		// Token: 0x0400014A RID: 330
		FileLockedWithWriters,
		// Token: 0x0400014B RID: 331
		Informational = 1073741824U,
		// Token: 0x0400014C RID: 332
		ObjectNameExists = 1073741824U,
		// Token: 0x0400014D RID: 333
		ThreadWasSuspended,
		// Token: 0x0400014E RID: 334
		WorkingSetLimitRange,
		// Token: 0x0400014F RID: 335
		ImageNotAtBase,
		// Token: 0x04000150 RID: 336
		RegistryRecovered = 1073741833U,
		// Token: 0x04000151 RID: 337
		Warning = 2147483648U,
		// Token: 0x04000152 RID: 338
		GuardPageViolation,
		// Token: 0x04000153 RID: 339
		DatatypeMisalignment,
		// Token: 0x04000154 RID: 340
		Breakpoint,
		// Token: 0x04000155 RID: 341
		SingleStep,
		// Token: 0x04000156 RID: 342
		BufferOverflow,
		// Token: 0x04000157 RID: 343
		NoMoreFiles,
		// Token: 0x04000158 RID: 344
		HandlesClosed = 2147483658U,
		// Token: 0x04000159 RID: 345
		PartialCopy = 2147483661U,
		// Token: 0x0400015A RID: 346
		DeviceBusy = 2147483665U,
		// Token: 0x0400015B RID: 347
		InvalidEaName = 2147483667U,
		// Token: 0x0400015C RID: 348
		EaListInconsistent,
		// Token: 0x0400015D RID: 349
		NoMoreEntries = 2147483674U,
		// Token: 0x0400015E RID: 350
		LongJump = 2147483686U,
		// Token: 0x0400015F RID: 351
		DllMightBeInsecure = 2147483691U,
		// Token: 0x04000160 RID: 352
		Error = 3221225472U,
		// Token: 0x04000161 RID: 353
		Unsuccessful,
		// Token: 0x04000162 RID: 354
		NotImplemented,
		// Token: 0x04000163 RID: 355
		InvalidInfoClass,
		// Token: 0x04000164 RID: 356
		InfoLengthMismatch,
		// Token: 0x04000165 RID: 357
		AccessViolation,
		// Token: 0x04000166 RID: 358
		InPageError,
		// Token: 0x04000167 RID: 359
		PagefileQuota,
		// Token: 0x04000168 RID: 360
		InvalidHandle,
		// Token: 0x04000169 RID: 361
		BadInitialStack,
		// Token: 0x0400016A RID: 362
		BadInitialPc,
		// Token: 0x0400016B RID: 363
		InvalidCid,
		// Token: 0x0400016C RID: 364
		TimerNotCanceled,
		// Token: 0x0400016D RID: 365
		InvalidParameter,
		// Token: 0x0400016E RID: 366
		NoSuchDevice,
		// Token: 0x0400016F RID: 367
		NoSuchFile,
		// Token: 0x04000170 RID: 368
		InvalidDeviceRequest,
		// Token: 0x04000171 RID: 369
		EndOfFile,
		// Token: 0x04000172 RID: 370
		WrongVolume,
		// Token: 0x04000173 RID: 371
		NoMediaInDevice,
		// Token: 0x04000174 RID: 372
		NoMemory = 3221225495U,
		// Token: 0x04000175 RID: 373
		NotMappedView = 3221225497U,
		// Token: 0x04000176 RID: 374
		UnableToFreeVm,
		// Token: 0x04000177 RID: 375
		UnableToDeleteSection,
		// Token: 0x04000178 RID: 376
		IllegalInstruction = 3221225501U,
		// Token: 0x04000179 RID: 377
		AlreadyCommitted = 3221225505U,
		// Token: 0x0400017A RID: 378
		AccessDenied,
		// Token: 0x0400017B RID: 379
		BufferTooSmall,
		// Token: 0x0400017C RID: 380
		ObjectTypeMismatch,
		// Token: 0x0400017D RID: 381
		NonContinuableException,
		// Token: 0x0400017E RID: 382
		BadStack = 3221225512U,
		// Token: 0x0400017F RID: 383
		NotLocked = 3221225514U,
		// Token: 0x04000180 RID: 384
		NotCommitted = 3221225517U,
		// Token: 0x04000181 RID: 385
		InvalidParameterMix = 3221225520U,
		// Token: 0x04000182 RID: 386
		ObjectNameInvalid = 3221225523U,
		// Token: 0x04000183 RID: 387
		ObjectNameNotFound,
		// Token: 0x04000184 RID: 388
		ObjectNameCollision,
		// Token: 0x04000185 RID: 389
		ObjectPathInvalid = 3221225529U,
		// Token: 0x04000186 RID: 390
		ObjectPathNotFound,
		// Token: 0x04000187 RID: 391
		ObjectPathSyntaxBad,
		// Token: 0x04000188 RID: 392
		DataOverrun,
		// Token: 0x04000189 RID: 393
		DataLate,
		// Token: 0x0400018A RID: 394
		DataError,
		// Token: 0x0400018B RID: 395
		CrcError,
		// Token: 0x0400018C RID: 396
		SectionTooBig,
		// Token: 0x0400018D RID: 397
		PortConnectionRefused,
		// Token: 0x0400018E RID: 398
		InvalidPortHandle,
		// Token: 0x0400018F RID: 399
		SharingViolation,
		// Token: 0x04000190 RID: 400
		QuotaExceeded,
		// Token: 0x04000191 RID: 401
		InvalidPageProtection,
		// Token: 0x04000192 RID: 402
		MutantNotOwned,
		// Token: 0x04000193 RID: 403
		SemaphoreLimitExceeded,
		// Token: 0x04000194 RID: 404
		PortAlreadySet,
		// Token: 0x04000195 RID: 405
		SectionNotImage,
		// Token: 0x04000196 RID: 406
		SuspendCountExceeded,
		// Token: 0x04000197 RID: 407
		ThreadIsTerminating,
		// Token: 0x04000198 RID: 408
		BadWorkingSetLimit,
		// Token: 0x04000199 RID: 409
		IncompatibleFileMap,
		// Token: 0x0400019A RID: 410
		SectionProtection,
		// Token: 0x0400019B RID: 411
		EasNotSupported,
		// Token: 0x0400019C RID: 412
		EaTooLarge,
		// Token: 0x0400019D RID: 413
		NonExistentEaEntry,
		// Token: 0x0400019E RID: 414
		NoEasOnFile,
		// Token: 0x0400019F RID: 415
		EaCorruptError,
		// Token: 0x040001A0 RID: 416
		FileLockConflict,
		// Token: 0x040001A1 RID: 417
		LockNotGranted,
		// Token: 0x040001A2 RID: 418
		DeletePending,
		// Token: 0x040001A3 RID: 419
		CtlFileNotSupported,
		// Token: 0x040001A4 RID: 420
		UnknownRevision,
		// Token: 0x040001A5 RID: 421
		RevisionMismatch,
		// Token: 0x040001A6 RID: 422
		InvalidOwner,
		// Token: 0x040001A7 RID: 423
		InvalidPrimaryGroup,
		// Token: 0x040001A8 RID: 424
		NoImpersonationToken,
		// Token: 0x040001A9 RID: 425
		CantDisableMandatory,
		// Token: 0x040001AA RID: 426
		NoLogonServers,
		// Token: 0x040001AB RID: 427
		NoSuchLogonSession,
		// Token: 0x040001AC RID: 428
		NoSuchPrivilege,
		// Token: 0x040001AD RID: 429
		PrivilegeNotHeld,
		// Token: 0x040001AE RID: 430
		InvalidAccountName,
		// Token: 0x040001AF RID: 431
		UserExists,
		// Token: 0x040001B0 RID: 432
		NoSuchUser,
		// Token: 0x040001B1 RID: 433
		GroupExists,
		// Token: 0x040001B2 RID: 434
		NoSuchGroup,
		// Token: 0x040001B3 RID: 435
		MemberInGroup,
		// Token: 0x040001B4 RID: 436
		MemberNotInGroup,
		// Token: 0x040001B5 RID: 437
		LastAdmin,
		// Token: 0x040001B6 RID: 438
		WrongPassword,
		// Token: 0x040001B7 RID: 439
		IllFormedPassword,
		// Token: 0x040001B8 RID: 440
		PasswordRestriction,
		// Token: 0x040001B9 RID: 441
		LogonFailure,
		// Token: 0x040001BA RID: 442
		AccountRestriction,
		// Token: 0x040001BB RID: 443
		InvalidLogonHours,
		// Token: 0x040001BC RID: 444
		InvalidWorkstation,
		// Token: 0x040001BD RID: 445
		PasswordExpired,
		// Token: 0x040001BE RID: 446
		AccountDisabled,
		// Token: 0x040001BF RID: 447
		NoneMapped,
		// Token: 0x040001C0 RID: 448
		TooManyLuidsRequested,
		// Token: 0x040001C1 RID: 449
		LuidsExhausted,
		// Token: 0x040001C2 RID: 450
		InvalidSubAuthority,
		// Token: 0x040001C3 RID: 451
		InvalidAcl,
		// Token: 0x040001C4 RID: 452
		InvalidSid,
		// Token: 0x040001C5 RID: 453
		InvalidSecurityDescr,
		// Token: 0x040001C6 RID: 454
		ProcedureNotFound,
		// Token: 0x040001C7 RID: 455
		InvalidImageFormat,
		// Token: 0x040001C8 RID: 456
		NoToken,
		// Token: 0x040001C9 RID: 457
		BadInheritanceAcl,
		// Token: 0x040001CA RID: 458
		RangeNotLocked,
		// Token: 0x040001CB RID: 459
		DiskFull,
		// Token: 0x040001CC RID: 460
		ServerDisabled,
		// Token: 0x040001CD RID: 461
		ServerNotDisabled,
		// Token: 0x040001CE RID: 462
		TooManyGuidsRequested,
		// Token: 0x040001CF RID: 463
		GuidsExhausted,
		// Token: 0x040001D0 RID: 464
		InvalidIdAuthority,
		// Token: 0x040001D1 RID: 465
		AgentsExhausted,
		// Token: 0x040001D2 RID: 466
		InvalidVolumeLabel,
		// Token: 0x040001D3 RID: 467
		SectionNotExtended,
		// Token: 0x040001D4 RID: 468
		NotMappedData,
		// Token: 0x040001D5 RID: 469
		ResourceDataNotFound,
		// Token: 0x040001D6 RID: 470
		ResourceTypeNotFound,
		// Token: 0x040001D7 RID: 471
		ResourceNameNotFound,
		// Token: 0x040001D8 RID: 472
		ArrayBoundsExceeded,
		// Token: 0x040001D9 RID: 473
		FloatDenormalOperand,
		// Token: 0x040001DA RID: 474
		FloatDivideByZero,
		// Token: 0x040001DB RID: 475
		FloatInexactResult,
		// Token: 0x040001DC RID: 476
		FloatInvalidOperation,
		// Token: 0x040001DD RID: 477
		FloatOverflow,
		// Token: 0x040001DE RID: 478
		FloatStackCheck,
		// Token: 0x040001DF RID: 479
		FloatUnderflow,
		// Token: 0x040001E0 RID: 480
		IntegerDivideByZero,
		// Token: 0x040001E1 RID: 481
		IntegerOverflow,
		// Token: 0x040001E2 RID: 482
		PrivilegedInstruction,
		// Token: 0x040001E3 RID: 483
		TooManyPagingFiles,
		// Token: 0x040001E4 RID: 484
		FileInvalid,
		// Token: 0x040001E5 RID: 485
		InstanceNotAvailable = 3221225643U,
		// Token: 0x040001E6 RID: 486
		PipeNotAvailable,
		// Token: 0x040001E7 RID: 487
		InvalidPipeState,
		// Token: 0x040001E8 RID: 488
		PipeBusy,
		// Token: 0x040001E9 RID: 489
		IllegalFunction,
		// Token: 0x040001EA RID: 490
		PipeDisconnected,
		// Token: 0x040001EB RID: 491
		PipeClosing,
		// Token: 0x040001EC RID: 492
		PipeConnected,
		// Token: 0x040001ED RID: 493
		PipeListening,
		// Token: 0x040001EE RID: 494
		InvalidReadMode,
		// Token: 0x040001EF RID: 495
		IoTimeout,
		// Token: 0x040001F0 RID: 496
		FileForcedClosed,
		// Token: 0x040001F1 RID: 497
		ProfilingNotStarted,
		// Token: 0x040001F2 RID: 498
		ProfilingNotStopped,
		// Token: 0x040001F3 RID: 499
		NotSameDevice = 3221225684U,
		// Token: 0x040001F4 RID: 500
		FileRenamed,
		// Token: 0x040001F5 RID: 501
		CantWait = 3221225688U,
		// Token: 0x040001F6 RID: 502
		PipeEmpty,
		// Token: 0x040001F7 RID: 503
		CantTerminateSelf = 3221225691U,
		// Token: 0x040001F8 RID: 504
		InternalError = 3221225701U,
		// Token: 0x040001F9 RID: 505
		InvalidParameter1 = 3221225711U,
		// Token: 0x040001FA RID: 506
		InvalidParameter2,
		// Token: 0x040001FB RID: 507
		InvalidParameter3,
		// Token: 0x040001FC RID: 508
		InvalidParameter4,
		// Token: 0x040001FD RID: 509
		InvalidParameter5,
		// Token: 0x040001FE RID: 510
		InvalidParameter6,
		// Token: 0x040001FF RID: 511
		InvalidParameter7,
		// Token: 0x04000200 RID: 512
		InvalidParameter8,
		// Token: 0x04000201 RID: 513
		InvalidParameter9,
		// Token: 0x04000202 RID: 514
		InvalidParameter10,
		// Token: 0x04000203 RID: 515
		InvalidParameter11,
		// Token: 0x04000204 RID: 516
		InvalidParameter12,
		// Token: 0x04000205 RID: 517
		MappedFileSizeZero = 3221225758U,
		// Token: 0x04000206 RID: 518
		TooManyOpenedFiles,
		// Token: 0x04000207 RID: 519
		Cancelled,
		// Token: 0x04000208 RID: 520
		CannotDelete,
		// Token: 0x04000209 RID: 521
		InvalidComputerName,
		// Token: 0x0400020A RID: 522
		FileDeleted,
		// Token: 0x0400020B RID: 523
		SpecialAccount,
		// Token: 0x0400020C RID: 524
		SpecialGroup,
		// Token: 0x0400020D RID: 525
		SpecialUser,
		// Token: 0x0400020E RID: 526
		MembersPrimaryGroup,
		// Token: 0x0400020F RID: 527
		FileClosed,
		// Token: 0x04000210 RID: 528
		TooManyThreads,
		// Token: 0x04000211 RID: 529
		ThreadNotInProcess,
		// Token: 0x04000212 RID: 530
		TokenAlreadyInUse,
		// Token: 0x04000213 RID: 531
		PagefileQuotaExceeded,
		// Token: 0x04000214 RID: 532
		CommitmentLimit,
		// Token: 0x04000215 RID: 533
		InvalidImageLeFormat,
		// Token: 0x04000216 RID: 534
		InvalidImageNotMz,
		// Token: 0x04000217 RID: 535
		InvalidImageProtect,
		// Token: 0x04000218 RID: 536
		InvalidImageWin16,
		// Token: 0x04000219 RID: 537
		LogonServer,
		// Token: 0x0400021A RID: 538
		DifferenceAtDc,
		// Token: 0x0400021B RID: 539
		SynchronizationRequired,
		// Token: 0x0400021C RID: 540
		DllNotFound,
		// Token: 0x0400021D RID: 541
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x0400021E RID: 542
		OrdinalNotFound,
		// Token: 0x0400021F RID: 543
		EntryPointNotFound,
		// Token: 0x04000220 RID: 544
		ControlCExit,
		// Token: 0x04000221 RID: 545
		PortNotSet = 3221226323U,
		// Token: 0x04000222 RID: 546
		DebuggerInactive,
		// Token: 0x04000223 RID: 547
		CallbackBypass = 3221226755U,
		// Token: 0x04000224 RID: 548
		PortClosed = 3221227264U,
		// Token: 0x04000225 RID: 549
		MessageLost,
		// Token: 0x04000226 RID: 550
		InvalidMessage,
		// Token: 0x04000227 RID: 551
		RequestCanceled,
		// Token: 0x04000228 RID: 552
		RecursiveDispatch,
		// Token: 0x04000229 RID: 553
		LpcReceiveBufferExpected,
		// Token: 0x0400022A RID: 554
		LpcInvalidConnectionUsage,
		// Token: 0x0400022B RID: 555
		LpcRequestsNotAllowed,
		// Token: 0x0400022C RID: 556
		ResourceInUse,
		// Token: 0x0400022D RID: 557
		ProcessIsProtected = 3221227282U,
		// Token: 0x0400022E RID: 558
		VolumeDirty = 3221227526U,
		// Token: 0x0400022F RID: 559
		FileCheckedOut = 3221227777U,
		// Token: 0x04000230 RID: 560
		CheckOutRequired,
		// Token: 0x04000231 RID: 561
		BadFileType,
		// Token: 0x04000232 RID: 562
		FileTooLarge,
		// Token: 0x04000233 RID: 563
		FormsAuthRequired,
		// Token: 0x04000234 RID: 564
		VirusInfected,
		// Token: 0x04000235 RID: 565
		VirusDeleted,
		// Token: 0x04000236 RID: 566
		TransactionalConflict = 3222863873U,
		// Token: 0x04000237 RID: 567
		InvalidTransaction,
		// Token: 0x04000238 RID: 568
		TransactionNotActive,
		// Token: 0x04000239 RID: 569
		TmInitializationFailed,
		// Token: 0x0400023A RID: 570
		RmNotActive,
		// Token: 0x0400023B RID: 571
		RmMetadataCorrupt,
		// Token: 0x0400023C RID: 572
		TransactionNotJoined,
		// Token: 0x0400023D RID: 573
		DirectoryNotRm,
		// Token: 0x0400023E RID: 574
		CouldNotResizeLog,
		// Token: 0x0400023F RID: 575
		TransactionsUnsupportedRemote,
		// Token: 0x04000240 RID: 576
		LogResizeInvalidSize,
		// Token: 0x04000241 RID: 577
		RemoteFileVersionMismatch,
		// Token: 0x04000242 RID: 578
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x04000243 RID: 579
		TransactionPropagationFailed,
		// Token: 0x04000244 RID: 580
		CrmProtocolNotFound,
		// Token: 0x04000245 RID: 581
		TransactionSuperiorExists,
		// Token: 0x04000246 RID: 582
		TransactionRequestNotValid,
		// Token: 0x04000247 RID: 583
		TransactionNotRequested,
		// Token: 0x04000248 RID: 584
		TransactionAlreadyAborted,
		// Token: 0x04000249 RID: 585
		TransactionAlreadyCommitted,
		// Token: 0x0400024A RID: 586
		TransactionInvalidMarshallBuffer,
		// Token: 0x0400024B RID: 587
		CurrentTransactionNotValid,
		// Token: 0x0400024C RID: 588
		LogGrowthFailed,
		// Token: 0x0400024D RID: 589
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x0400024E RID: 590
		StreamMiniversionNotFound,
		// Token: 0x0400024F RID: 591
		StreamMiniversionNotValid,
		// Token: 0x04000250 RID: 592
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x04000251 RID: 593
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x04000252 RID: 594
		CantCreateMoreStreamMiniversions,
		// Token: 0x04000253 RID: 595
		HandleNoLongerValid = 3222863912U,
		// Token: 0x04000254 RID: 596
		NoTxfMetadata,
		// Token: 0x04000255 RID: 597
		LogCorruptionDetected = 3222863920U,
		// Token: 0x04000256 RID: 598
		CantRecoverWithHandleOpen,
		// Token: 0x04000257 RID: 599
		RmDisconnected,
		// Token: 0x04000258 RID: 600
		EnlistmentNotSuperior,
		// Token: 0x04000259 RID: 601
		RecoveryNotNeeded,
		// Token: 0x0400025A RID: 602
		RmAlreadyStarted,
		// Token: 0x0400025B RID: 603
		FileIdentityNotPersistent,
		// Token: 0x0400025C RID: 604
		CantBreakTransactionalDependency,
		// Token: 0x0400025D RID: 605
		CantCrossRmBoundary,
		// Token: 0x0400025E RID: 606
		TxfDirNotEmpty,
		// Token: 0x0400025F RID: 607
		IndoubtTransactionsExist,
		// Token: 0x04000260 RID: 608
		TmVolatile,
		// Token: 0x04000261 RID: 609
		RollbackTimerExpired,
		// Token: 0x04000262 RID: 610
		TxfAttributeCorrupt,
		// Token: 0x04000263 RID: 611
		EfsNotAllowedInTransaction,
		// Token: 0x04000264 RID: 612
		TransactionalOpenNotAllowed,
		// Token: 0x04000265 RID: 613
		TransactedMappingUnsupportedRemote,
		// Token: 0x04000266 RID: 614
		TxfMetadataAlreadyPresent,
		// Token: 0x04000267 RID: 615
		TransactionScopeCallbacksNotSet,
		// Token: 0x04000268 RID: 616
		TransactionRequiredPromotion,
		// Token: 0x04000269 RID: 617
		CannotExecuteFileInTransaction,
		// Token: 0x0400026A RID: 618
		TransactionsNotFrozen,
		// Token: 0x0400026B RID: 619
		MaximumNtStatus = 4294967295U
	}
}
